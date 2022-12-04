using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    
    #region Private vals
    private InputMaster controls;
    private Vector3 velocity;
    private Vector2 move;
    private CharacterController controller;
    private bool isGrounded;
    private bool isHoldingJump;
    [SerializeField] private ItemInHand[] items;
    private ItemInHand selectedItem;
    #endregion
    #region SerializeFielded vals
    [SerializeField] [Range(-1000, 1000)] private float movementSpeed = 100f;
    [SerializeField] [Range(-1000, 1000)] private float gravity = -9.81f;
    [SerializeField] [Range(-1000, 1000)] private float jumpHeight = 2.4f;
    [SerializeField] [Range(-1000, 1000)] private float holdJumpDelta = 6f;
    [SerializeField] [Range(-1000, 1000)] private float publicErrorMargin = 6f;
    #endregion
    #region Public vals
    public Transform groundCheck;
    public float distanceToGround = 0.4f;
    public LayerMask groundMask;
    public static PlayerController Instance;
    public static bool ControlEnabled = true;
    #endregion
    private void Awake()
    {
        Instance = this;
        controls = new InputMaster();
        controller = GetComponent<CharacterController>();
        items = GetComponentsInChildren<ItemInHand>(true);
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
    public static void SetControl(bool value) => ControlEnabled = value;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Fire"))
        {
            PlayerStateUI.Instance.TakeDamage(0.5f);
            return;
        }

        if (other.CompareTag("MonsterDamage"))
        {
            PlayerStateUI.Instance.TakeDamage();
            return;
        }
    }
    private void Update()
    {
        if (!ControlEnabled) return;
        Gravity();
        PlayerMovement();
        Jump();

        PlayerAction();
    }

    void PlayerAction()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (selectedItem != null)
                selectedItem.ToolAnimation();
        }
    }

    private void Gravity()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, distanceToGround, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
    private void PlayerMovement()
    {
        move = controls.Player.Movment.ReadValue<Vector2>();
        Vector3 movement = (move.y * transform.forward) + (move.x * transform.right);
        if (movement.normalized.sqrMagnitude < 0.01f)
        {
            MouseLook.Instance.Running(false);
            StepsSound.StopSteps();
            return;
        }

        float targetSpeed = movementSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            targetSpeed *= 2;
            MouseLook.Instance.Running(true);
            StepsSound.PlaySteps(0.3f);
        }
        else
        {
            MouseLook.Instance.Running(false);
            StepsSound.PlaySteps(0.7f);

        }

        if (!isGrounded) StepsSound.StopSteps();

        controller.Move(movement * targetSpeed * Time.deltaTime);
    }
    private void Jump()
    {
        //if (!isGrounded) return;


        if (controls.Player.Jump.triggered && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            isHoldingJump = true;

        }

        else if (controls.Player.Jump.IsPressed() && isHoldingJump)
        {
            velocity.y += holdJumpDelta * Time.deltaTime;
            if (NumIsCloseToTarget(velocity.y, 0, publicErrorMargin))
            {
                isHoldingJump = false;
            }
        }

        else if (controls.Player.Jump.WasReleasedThisFrame())
        {
            isHoldingJump = false;
        }
    }

    public void SwitchTool(ItemType itemType)
    {
        //Debug.Log(itemType.ToString());
        if (selectedItem != null) selectedItem.gameObject.SetActive(false);

        foreach (var item in items)
        {
            if (item.type == itemType)
            {
                item.gameObject.SetActive(true);
                selectedItem = item;
                return;
            }
            //item.gameObject.SetActive(false);
        }
    }

    private bool NumIsCloseToTarget(float valueToBeVerified, float target, float errorMargin)
    => (valueToBeVerified > target - errorMargin) && (valueToBeVerified < target + errorMargin);
}


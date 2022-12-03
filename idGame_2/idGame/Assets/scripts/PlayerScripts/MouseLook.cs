using UnityEngine;
using ProjectUtils;
public class MouseLook : MonoBehaviour
{
    public static MouseLook Instance;
    #region Private vals
    private InputMaster controls;
    private Vector2 mouseLook;
    private float Xrotation = 0;
    #endregion
    #region SerializeFielded vals
    [SerializeField] [Range(0, 1000)] private float mouseSensetivity = 100f;
    [SerializeField] private Transform playerBody;
    [SerializeField] private Animator camAnim;
    #endregion
    private void Awake()
    {
        controls = new InputMaster();
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Instance = this;
    }

    public void Running(bool value) => camAnim.SetBool("Running", value);

    public void Shake(float shakeTime = 0.4f)
    {
        camAnim.SetBool("Shaking", true);
        this.ActionAfterTime(shakeTime, StopShake);
    }
    public void StopShake() => camAnim.SetBool("Shaking", false);

    private void Update()
    {
        if (!PlayerController.ControlEnabled) return;
        Look();
    }
    private void Look()
    {
        mouseLook = controls.Player.Look.ReadValue<Vector2>();
        float mouseX = mouseLook.x * mouseSensetivity * Time.deltaTime;
        float mouseY = mouseLook.y * mouseSensetivity * Time.deltaTime;
        Xrotation -= mouseY;
        Xrotation = Mathf.Clamp(Xrotation, -90, 90);
        transform.localRotation = Quaternion.Euler(Xrotation, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX);
    }
    private void OnEnable()
    {
        controls.Enable();

    }
    private void OnDisable()
    {
        controls.Disable();
    }



}

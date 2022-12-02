using UnityEngine;

public class MouseLook : MonoBehaviour
{
    #region Private vals
    private InputMaster controls;
    private Vector2 mouseLook;
    private float Xrotation = 0;
    #endregion
    #region SerializeFielded vals
    [SerializeField] [Range(0, 1000)] private float mouseSensetivity = 100f;
    [SerializeField] private Transform playerBody;
    #endregion
    private void Awake()
    {
        controls = new InputMaster();
        Cursor.lockState= CursorLockMode.Confined;
        Cursor.visible = true;
    }
    private void Update()
    {
        Look();
    }
    private void Look()
    {
        if (!controls.Player.EnableLook.IsPressed()) return;
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

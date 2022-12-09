using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseUI : MonoBehaviour
{
    public static PauseUI Instance;

    public static bool IsShown { get; set; }

    [SerializeField] private Canvas canvas;

    [SerializeField] private Button btnResume;
    [SerializeField] private Button btnControls;
    [SerializeField] private Button btnOptions;
    [SerializeField] private Button btnMainMenu;
    [SerializeField] private Button btnExit;

    void Start()
    {
        Instance = this;
        Initialize();
        Hide();
    }

    void Initialize()
    {
        btnResume.onClick.AddListener(() =>
        {
            Hide();
        });
        btnControls.onClick.AddListener(() =>
        {
            // Open menu options
            ControlsUI.Show();
            OptionsUI.Hide();
        });
        btnOptions.onClick.AddListener(() =>
        {
            // Open menu options
            OptionsUI.Show();
            ControlsUI.Hide();

        });

        btnMainMenu.onClick.AddListener(() =>
        {
            ChangeSceneUI.ChangeScene("Main Menu");
        });
        btnExit.onClick.AddListener(Application.Quit);
    }

    public static void Show()
    {
        IsShown = true;
        Instance.canvas.enabled = true;
        Time.timeScale = 0;
        PlayerController.ControlEnabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public static void Hide()
    {
        IsShown = false;
        Time.timeScale = 1;
        Instance.canvas.enabled = false;
        PlayerController.ControlEnabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        OptionsUI.Hide();
        ControlsUI.Hide();
    }
}

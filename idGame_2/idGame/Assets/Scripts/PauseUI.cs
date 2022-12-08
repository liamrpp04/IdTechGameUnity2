using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseUI : MonoBehaviour
{
    public static PauseUI Instance;

    [SerializeField] private Canvas canvas;

    [SerializeField] private Button btnResume;
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

        });
        btnOptions.onClick.AddListener(() =>
        {
            // Open menu options
            OptionsUI.Show();
        });

        btnMainMenu.onClick.AddListener(() =>
        {
            ChangeSceneUI.ChangeScene("Main Menu");
        });
        btnExit.onClick.AddListener(Application.Quit);
    }

    public static void Show()
    {
        Instance.canvas.enabled = true;
        Time.timeScale = 0;
    }
    public static void Hide()
    {
        Time.timeScale = 1;
        Instance.canvas.enabled = false;
        OptionsUI.Hide();
    }
}

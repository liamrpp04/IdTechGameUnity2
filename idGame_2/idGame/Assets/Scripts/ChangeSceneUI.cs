using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ChangeSceneUI : MonoBehaviour
{
    private static ChangeSceneUI Instance;
    [SerializeField] private Image fadeImage;

    public static void ChangeScene(string sceneName) => Instance._ChangeScene(sceneName);

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        LetShowScene();
        SceneManager.sceneLoaded += (Scene scene, LoadSceneMode mode) => LetShowScene();
    }

    private void LetShowScene()
    {
        fadeImage.color = Color.black;
        fadeImage.DOFade(0, 1f).SetDelay(0.1f).OnComplete(() =>
        {

        });
    }

    private void _ChangeScene(string sceneName)
    {
        fadeImage.DOFade(1, 1f).OnComplete(() =>
        {
            SceneManager.LoadScene(sceneName);
        });
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectUtils;
using UnityEngine.Events;

public class Level2Manager : MonoBehaviour
{
    #region Private vals

    #endregion
    #region SerializeFielded vals
    //[SerializeField] private PlayerController player;
    [SerializeField] private Transform sourceStartT;
    [SerializeField] private Transform sourceStartMT;
    [SerializeField] private GameObject[] toEnableAfterTransition;
    [SerializeField] private GameObject[] toEnableDuringTransition;
    [SerializeField] private GameObject[] toDestroyAtBeginIfTransition;
    #endregion
    #region Public vals
    public static Level2Manager Instance;
    #endregion

    public void StartFinishGame()
    {
        this.ActionAfterTime(13f, () => {
            ChangeSceneUI.ChangeScene("Final");
        });
    }

    private void Awake()
    {
        Instance = this;

    }

    public static void EnableAfterTransitionObjects()
    {
        foreach (var item in Instance.toEnableAfterTransition)
        {
            item.gameObject.SetActive(true);
        }
    }
    //public void ChangePlayer()
    //{
    //    var before = PlayerController.Instance;
    //    PlayerController.Instance = player;
    //}

    private void Start()
    {
        this.ActionAfterTime(1.2f, () =>
        {
            ObjectivesUI.Show(() =>
            {
                ObjectivesUI.AddObjective("Find a way to scape the zone");
            });
        });

        if (!Level1Manager.LevelTransition) return;

        foreach (var obj in toEnableDuringTransition) obj.gameObject.SetActive(false);

        foreach (var obj in toDestroyAtBeginIfTransition) Destroy(obj);
        this.ActionAfterTime(5.6f, () =>
        {
            //if (PlayerController.Instance != null)
            //{
            //    Transform playerT = PlayerController.Instance.transform;
            //    playerT.position = sourceStartT.position;
            //    playerT.rotation = sourceStartT.rotation;
            //    Destroy(sourceStartT.gameObject);
            //}
            foreach (var obj in toEnableDuringTransition) obj.gameObject.SetActive(true);

        });


        foreach (var item in Instance.toEnableAfterTransition)
        {
            item.gameObject.SetActive(false);
        }
    }
    //public static void TeleportMonster()
    //{
    //    if (Monster.Instance != null)
    //    {
    //        Transform monsterT = Monster.Instance.transform;
    //        Monster.Instance.ForcePosition(Instance.sourceStartMT.position);
    //        Destroy(Instance.sourceStartMT.gameObject);
    //    }
    //}

    //public static void ShowPopup(string message) => ShortPopupUI.Show(message);
}

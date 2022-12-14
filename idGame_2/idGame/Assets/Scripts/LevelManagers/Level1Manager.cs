using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using ProjectUtils;

public class Level1Manager : MonoBehaviour
{
    public static bool RespawnOnLevel1 = false;
    #region Private vals
    #endregion
    #region SerializeFielded vals
    [SerializeField] private GameObject[] toDisableAfterTransition;
    #endregion
    #region Public vals
    public static Level1Manager Instance;
    public UnityEvent AfterLevel2Load;
    public static bool LevelTransition;
    #endregion
    public void SetLevelTransition(bool value) => LevelTransition = value;
    private void Awake()
    {
        Application.targetFrameRate = 60;
        Instance = this;
    }
    void Start()
    {
        RespawnOnLevel1 = true;
        //this.ActionAfterTime(1.2f, () =>
        //{
        //    ObjectivesUI.Show(() =>
        //    {
        //        ObjectivesUI.AddObjective("1", "Get out the zone");
        //    });
        //});
    }

    public void FirstObjective()
    {
        ObjectivesUI.Show(() =>
        {
            ObjectivesUI.AddObjective("Get out the zone", "Get out the zone");
        });
    }

    public void LoadLevel2()
    {
        GamplayInvetory.SaveI();
        ChangeSceneUI.ChangeSceneAdditive("Level 2", null, () => { AfterLevel2Load.Invoke(); RespawnOnLevel1 = false; });
    }
    public void OnMonsterAppear()
    {
        ObjectivesUI.CompleteObjective("1", () => { ObjectivesUI.AddObjective("2", "Escape the beast"); });
    }
    //public static void TeleportMonsterActivation()
    //{
    //    //Level2Manager.TeleportMonster();
    //}

    public static void AfterMonsterFinalTransition()
    {
        foreach (var item in Instance.toDisableAfterTransition)
        {
            item.gameObject.SetActive(false);
        }
        Level2Manager.EnableAfterTransitionObjects();
        LevelTransition = false;
    }
}

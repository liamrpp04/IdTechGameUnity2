using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using ProjectUtils;

public class Level1Manager : MonoBehaviour
{
    #region Private vals
    #endregion
    #region SerializeFielded vals
    #endregion
    #region Public vals
    public UnityEvent AfterLevel2Load;
    public static bool LevelTransition;
    #endregion
    public void SetLevelTransition(bool value) => LevelTransition = value;
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    void Start()
    {
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
            ObjectivesUI.AddObjective("1", "Get out the zone");
        });
    }

    public void LoadLevel2() => ChangeSceneUI.ChangeSceneAdditive("Level 2", null, () => { AfterLevel2Load.Invoke(); });
    public void OnMonsterAppear()
    {
        ObjectivesUI.CompleteObjective("1", () => { ObjectivesUI.AddObjective("2", "Escape the beast"); });
    }
    public static void TeleportMonsterActivation()
    {
        Level2Manager.TeleportMonster();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using ProjectUtils;

public class Level1Manager : MonoBehaviour
{
    public UnityEvent AfterLevel2Load;
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    void Start()
    {
        this.ActionAfterTime(2f, () =>
        {
            ObjectivesUI.Show(() =>
            {
                ObjectivesUI.AddObjective("1", "Investigate the zone");
            });
        });
    }
    public void LoadLevel2() => ChangeSceneUI.ChangeSceneAdditive("Level 2", null, () => { AfterLevel2Load.Invoke(); });
    public void OnMonsterAppear()
    {
        ObjectivesUI.CompleteObjective("1", () =>{ObjectivesUI.AddObjective("2", "Escape the beast");});
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectUtils;

public class Level1Manager : MonoBehaviour
{
    // Start is called before the first frame update
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

    public void OnMonsterAppear()
    {
        ObjectivesUI.CompleteObjective("1", () =>
        {
            ObjectivesUI.AddObjective("2", "Escape the beast");
        });

    }

}

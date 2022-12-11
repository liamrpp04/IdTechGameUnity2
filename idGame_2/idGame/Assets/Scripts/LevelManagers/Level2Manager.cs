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
    [SerializeField] private Transform sourceStartT;
    [SerializeField] private Transform sourceStartMT;
    #endregion
    #region Public vals
    public static Level2Manager Instance;
    #endregion

    

    private void Awake()
    {
        Instance = this;

    }

    private void Start()
    {
        if (!Level1Manager.LevelTransition) return;
        this.ActionAfterTime(2f, () =>
        {
            if (PlayerController.Instance != null)
            {
                Transform playerT = PlayerController.Instance.transform;
                playerT.position = sourceStartT.position;
                playerT.rotation = sourceStartT.rotation;
                Destroy(sourceStartT.gameObject);
            }
            
        });

    }
    public static void TeleportMonster()
    {
        if (Monster.Instance != null)
        {
            Transform monsterT = Monster.Instance.transform;
            monsterT.position = Instance.sourceStartMT.position;
            monsterT.rotation = Instance.sourceStartMT.rotation;
            Destroy(Instance.sourceStartMT.gameObject);
        }
    }

}

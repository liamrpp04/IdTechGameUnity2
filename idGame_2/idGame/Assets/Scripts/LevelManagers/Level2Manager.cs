using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectUtils;

public class Level2Manager : MonoBehaviour
{
    public static Level2Manager Instance;
    [SerializeField] private Transform sourceStartT;

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

}

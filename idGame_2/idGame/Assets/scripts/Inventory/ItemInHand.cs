using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInHand : MonoBehaviour
{
    #region Private vals
    private Animator anim;
    #endregion
    #region Public vals
    public ItemType type;
    public float power = 20;
    #endregion
    private void OnEnable()
    {
        if (!anim) anim = GetComponent<Animator>();
    }

    public void ToolAnimation()
    {
        if (anim == null) return;
        anim.SetTrigger("ToolAnimation");
    }
}
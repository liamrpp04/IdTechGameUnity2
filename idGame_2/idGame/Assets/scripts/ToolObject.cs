using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ToolType
{
    None,
    PickAxe,
    Axe
}

[RequireComponent(typeof(Animator))]
public class ToolObject : MonoBehaviour
{
    public ToolType type;
    public float power = 20;
    private Animator anim;

    private void OnEnable()
    {
        if (!anim) anim = GetComponent<Animator>();
    }

    public void Attack()
    {
        anim.SetTrigger("Attack");
    }
}
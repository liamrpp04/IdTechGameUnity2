using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    None,
    PickAxe,
    Axe
}

[RequireComponent(typeof(Animator))]
public class ItemInHand : MonoBehaviour
{
    public ItemType type;
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
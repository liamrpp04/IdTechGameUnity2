using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDamaged : MonoBehaviour
{
    [SerializeField] private Texture2D damaged_1;
    [SerializeField] private Texture2D damaged_2;

    int damageAllowed = 3;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tool"))
        {
            damageAllowed--;
            Material mat = new Material(GetComponent<MeshRenderer>().sharedMaterial);

            if (damageAllowed == 2)
            {
                mat.mainTexture = damaged_1;
                GetComponent<MeshRenderer>().sharedMaterial = mat;

            }
            else if (damageAllowed == 1)
            {
                mat.mainTexture = damaged_2;
                GetComponent<MeshRenderer>().sharedMaterial = mat;
            }
            else
            {
                Destroy(gameObject);
            }
            SoundManager.PlayOneShot("box_damaged", 0.5f);
        }
    }
}

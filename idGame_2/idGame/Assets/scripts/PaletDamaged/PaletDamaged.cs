using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaletDamaged : MonoBehaviour
{
    int index;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("a");
        if (other.CompareTag("Tool"))
        {
            //Debug.Log("e");

            transform.GetChild(index).gameObject.SetActive(false);
            SoundManager.PlayOneShot("box_damaged", 0.5f);
            if (index == transform.childCount - 1)
            {
                Destroy(gameObject);
                return;
            }
            index += 1;
            transform.GetChild(index).gameObject.SetActive(true);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("a");
    //    if (collision.gameObject.tag == "Tool")
    //    {
    //        Debug.Log("e");

    //        transform.GetChild(index).gameObject.SetActive(false);
    //        index += 1;
    //        transform.GetChild(index).gameObject.SetActive(true);
    //    }
    //}
}

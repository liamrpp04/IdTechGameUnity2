using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalPath : MonoBehaviour
{
    private int activeSign = 0;

    private void Start()
    {
        for (int i = 1; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        transform.GetChild(activeSign).gameObject.SetActive(true);
    }

    public void Next()
    {
        transform.GetChild(activeSign).gameObject.SetActive(false);
        if (activeSign + 1 >= transform.childCount) return;

        activeSign += 1;
        transform.GetChild(activeSign).gameObject.SetActive(true);
    }
}

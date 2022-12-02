using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerDetector : MonoBehaviour
{
    [SerializeField] private UnityEvent OnEnter;
    [SerializeField] private string targetTag = "Player";
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            OnEnter?.Invoke();
            Destroy(gameObject);
        }
    }
}

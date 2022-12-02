using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnObjectEnabled : MonoBehaviour
{
    [SerializeField] private UnityEngine.Events.UnityEvent OnEnabled;
    private void OnEnable()
    {
        OnEnabled?.Invoke();
    }
}

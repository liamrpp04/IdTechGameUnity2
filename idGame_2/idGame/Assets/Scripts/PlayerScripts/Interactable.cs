using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Interactable : MonoBehaviour
{
    public KeyCode keyToPress;
    public string description;
    [SerializeField] private ItemData itemRequired;
    [SerializeField] private int amountRequired = 1;
    [SerializeField] private UnityEvent OnPress;
    [SerializeField] private UnityEvent OnFailed;

    public void Evaluate()
    {
        if (itemRequired == null || amountRequired == 0)
        {
            OnPress?.Invoke();
            return;
        }

        InventoryItem item = Inventory.Get(itemRequired);
        if(item == null)
        {
            OnFailed?.Invoke();
            return;
        }
        if (item.stackSize >= amountRequired)
        {
            Inventory.Remove(itemRequired, amountRequired);
            OnPress?.Invoke();
        }
        else
            OnFailed?.Invoke();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Interactable : MonoBehaviour
{
    public KeyCode keyToPress;
    public string description;
    public ItemData itemRequired;
    public int amountRequired = 1;
    public bool devMode = false;

    [SerializeField] private UnityEvent OnSuccess;
    [SerializeField] private UnityEvent OnFailed;

    public void Evaluate(ItemInHand itemInHand)
    {
        if (devMode)
        {
            SuccessInteraction();
            return;
        }
        if (itemRequired == null || amountRequired == 0)
        {
            SuccessInteraction();
            return;
        }

        if (itemInHand == null || itemRequired != itemInHand.data)
        {
            FailInteraction();
            return;
        }

        InventoryItem inventoryItem = Inventory.Get(itemRequired);

        if (inventoryItem.stackSize >= amountRequired)
        {
            Inventory.Remove(itemRequired, amountRequired);
            SuccessInteraction();
            //
        }
        else
        {
            FailInteraction();
        }
    }

    void FailInteraction()
    {
        ShortPopupUI.ShowFailedInteraction(this);
        OnFailed?.Invoke();
    }

    void SuccessInteraction()
    {
        OnSuccess?.Invoke();
        Clear();
    }

    private void Clear()
    {
        gameObject.layer = 0;
    }
}

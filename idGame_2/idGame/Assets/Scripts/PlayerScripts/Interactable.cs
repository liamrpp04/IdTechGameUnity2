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

    [SerializeField] private UnityEvent OnSuccess;
    [SerializeField] private UnityEvent OnFailed;

    public void Evaluate(ItemInHand itemInHand)
    {
        if (itemRequired == null || amountRequired == 0)
        {
            OnSuccess?.Invoke();
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
            OnSuccess?.Invoke();
            //
            gameObject.SetActive(false);
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem
{
    public ItemData data { get; private set; }
    public int stackSize { get; private set; }

    public InventoryItem(ItemData item)
    {
        data = item;
        AddToStack();
    }

    public void AddToStack(int amount = 1)
    {
        stackSize += amount;
    }

    public void RemoveFromStack(int amount = 1)
    {
        stackSize -= amount;
    }
}

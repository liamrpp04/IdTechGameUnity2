using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public static Dictionary<ItemData, InventoryItem> items = new Dictionary<ItemData, InventoryItem>();

    public static void Add(ItemData itemData)
    {
        if (items.TryGetValue(itemData, out InventoryItem item))
        {
            if (item.data.toolType != ToolType.None) return;
            item.AddToStack();
            //GameplayUI.ToolsBar.Add(item);
            GamplayInvetory.Instance.UpdateSlotStack(item);
        }
        else
        {
            InventoryItem newItem = new InventoryItem(itemData);
            items.Add(itemData, newItem);
            GamplayInvetory.Instance.AddToIventory(newItem);

            //GameplayUI.ToolsBar.Add(newItem);

        }
    }

    public static void Remove(ItemData itemData)
    {
        if (items.TryGetValue(itemData, out InventoryItem item))
        {
            item.RemoveFromStack();
            if (item.stackSize == 0)
            {
                items.Remove(itemData);
            }
        }
    }
}

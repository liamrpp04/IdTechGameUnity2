using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GamplayInvetory : MonoBehaviour
{
    public static GamplayInvetory Instance;
    #region Private vals
    private int selectedIndex = 0;
    InputMaster master;
    #endregion
    #region SerializeFielded vals
    [SerializeField] List<SlotUI> slots = new List<SlotUI>();

    #endregion
    #region Public vals

    #endregion
    private void Awake()
    {
        Instance = this;
        slots[selectedIndex].Select();
        master = new InputMaster();
        master.Enable();
    }

    private void OnEnable() =>master.Enable();
    private void OnDisable() => master.Disable();

    private void Update()
    {
        if (!PlayerController.ControlEnabled) return;
        //float scroll = Input.mouseScrollDelta.y;
        float scroll = Mouse.current.scroll.ReadValue().normalized.y;
        if (scroll > 0)
        {
            Select(selectedIndex - 1);
        }
        else if (scroll < 0)
        {
            Select(selectedIndex + 1);

        }

        SelectByNumbers();
    }

    void SelectByNumbers()
    {
        if (master.Inventory.P1.WasPressedThisFrame()) Select(0);
        if (master.Inventory.P2.WasPressedThisFrame()) Select(1);
        if (master.Inventory.P3.WasPressedThisFrame()) Select(2);
        if (master.Inventory.P4.WasPressedThisFrame()) Select(3);
        if (master.Inventory.P5.WasPressedThisFrame()) Select(4);
        if (master.Inventory.P6.WasPressedThisFrame()) Select(5);
        if (master.Inventory.P7.WasPressedThisFrame()) Select(6);
        if (master.Inventory.P8.WasPressedThisFrame()) Select(7);
        if (master.Inventory.P9.WasPressedThisFrame()) Select(8);
    }

    public void Select(int targetIndex)
    {
        //int target = next ? selectedIndex - 1 : selectedIndex + 1;
        //target = Mathf.Clamp(target, 0, slots.Count - 1);
        if (targetIndex == selectedIndex) return;
        if (targetIndex < 0) targetIndex = slots.Count - 1;
        else if (targetIndex > slots.Count - 1) targetIndex = 0;


        slots[selectedIndex].Deselect();
        slots[targetIndex].Select();
        selectedIndex = targetIndex;

    }

    public void Select(SlotUI slot)
    {
        if (slots[selectedIndex] == slot) return;

        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i] != slot) continue;

            slots[selectedIndex].Deselect();
            slot.Select();
            selectedIndex = i;
            break;
        }

    }


    public void AddToIventory(InventoryItem item)
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i].isSlotEmpty)
            {
                slots[i].ShowItemIcon(item); return;
            }
        }
    }

    public void Remove(InventoryItem item)
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i].isSlotEmpty) continue;

            if (slots[i].Item == item)
            {
                slots[i].Empty();
                return;
            }

        }
    }

    public void UpdateSlotStack(InventoryItem item)
    {
        for (int i = 0; i < slots.Count; i++)
        {
            SlotUI slot = slots[i];

            if (slot.Item == item)
            {
                slot.UpdateStackText();
                return;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class SlotUI : MonoBehaviour
{
    #region Private vals
    bool isSelected;
    //private ToolType toolType = ToolType.None;
    public InventoryItem Item { get; private set; }

    private static Color32 selectedColor = Color.white;
    private static Color32 defaultColor = new Color32(140, 142, 139, 255);
    #endregion
    #region SerializeFielded vals
    [SerializeField] Image itemIcon;
    [SerializeField] TMP_Text numTxt;
    //[SerializeField] Color selectedColor;
    //[SerializeField] Color defaultColor;
    #endregion
    #region Public vals
    public bool isSlotEmpty = true;
    #endregion

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => GamplayInvetory.Instance.Select(this));
    }

    public void ShowItemIcon(InventoryItem itemData)
    {
        itemIcon.gameObject.SetActive(true);
        itemIcon.sprite = itemData.data.itemSprite;
        itemIcon.color = itemData.data.itemColor;
        isSlotEmpty = false;
        //toolType = itemData.data.toolType;
        Item = itemData;
        if (isSelected) CheckTool();
    }

    public void Select()
    {
        GetComponent<Image>().color = selectedColor;
        transform.localScale = new Vector3(1.2f, 1.2f, 1);
        isSelected = true;
        CheckTool();
    }

    public void Deselect()
    {
        GetComponent<Image>().color = defaultColor;

        transform.localScale = Vector3.one;
        isSelected = false;

    }

    public void UpdateStackText()
    {
        if (Item.stackSize == 1)
        {
            numTxt.text = "";
            return;
        }
        numTxt.text = Item.stackSize.ToString();
    }

    void CheckTool()
    {
        if (Item == null)
        {
            PlayerController.Instance.SwitchTool(ToolType.None);
            return;
        }
        PlayerController.Instance.SwitchTool(Item.data.toolType);
    }
}

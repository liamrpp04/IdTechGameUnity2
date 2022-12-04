using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ItemType
{
    None,
    y,
    PickAxe,
    Axe,
    Key
}

[CreateAssetMenu(fileName = "ItemData", menuName = "ItemDatas/ItemData")]
public class ItemData : ScriptableObject
{
    #region Private vals

    #endregion
    #region SerializeFielded vals


    #endregion
    #region Public vals
    public ItemType itemType = ItemType.None;
    public string itemName;
    public Sprite itemSprite;
    public Color itemColor = Color.white;
    public bool isStackable;
    //public string itemType;
    #endregion
}

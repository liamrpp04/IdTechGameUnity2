using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ItemData", menuName = "ItemDatas/ItemData")]
public class ItemData : ScriptableObject
{
    #region Private vals

    #endregion
    #region SerializeFielded vals


    #endregion
    #region Public vals
    public ItemType toolType = ItemType.None;
    public string itemName;
    public Sprite itemSprite;
    public Color itemColor = Color.white;
    //public string itemType;
    #endregion
}

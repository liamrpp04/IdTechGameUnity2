using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    #region Private vals

    #endregion
    #region SerializeFielded vals


    #endregion
    #region Public vals
    public ItemData itemData;
    #endregion
    public ItemData CollectItem()
    {
        Destroy(gameObject);
        return itemData;
    }
}

using UnityEngine;

public class PickupItems : MonoBehaviour
{
    #region Private vals

    #endregion
    #region SerializeFielded vals


    #endregion
    #region Public vals

    #endregion
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CollectableItem"))
        {
            ItemData itemData = other.gameObject.GetComponent<CollectableItem>().CollectItem();
            //GamplayInvetory.Instance.AddToIventory(itemData);
            Inventory.Add(itemData);
        }
    }
}

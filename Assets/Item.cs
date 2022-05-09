using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Inventory playerInventory = other.GetComponent<Inventory>();

        if(playerInventory != null)
        {
            playerInventory.itemCollected();
            gameObject.SetActive(false);
        }
    }
}

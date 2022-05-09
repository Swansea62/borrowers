using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{
    public int numOfItems { get; private set; }

    public UnityEvent<Inventory> OnItemCollected;

    public void itemCollected()
    {
        numOfItems++;
        OnItemCollected.Invoke(this);
    }
}

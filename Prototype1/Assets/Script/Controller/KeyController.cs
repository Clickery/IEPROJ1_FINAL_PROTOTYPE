using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public bool isKeyInInventory;

    public void GetKey()
    {
        if (!isKeyInInventory)
        {
            isKeyInInventory = true;
            Debug.Log("Key is now in Inventory...");
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }
}

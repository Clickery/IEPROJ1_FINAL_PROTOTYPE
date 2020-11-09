using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickNPlaceController : MonoBehaviour
{
    public GameObject gameObjectBoxIndi;
    public GameObject gameObjectToPlace;
    public bool isInInventory;
    public bool isPlaced;

    public void PickNShowObj()
    {
        if (!isInInventory)
        {
            isInInventory = true;
            Debug.Log("Picked Up Object...");
            gameObjectBoxIndi.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    public void PlaceNRemove()
    {
        if (!isPlaced)
        {
            isPlaced = true;
            Debug.Log("Placed Object in Box Indicator...");
            gameObjectBoxIndi.SetActive(false);
            gameObjectToPlace.SetActive(true);
        }
    }
}

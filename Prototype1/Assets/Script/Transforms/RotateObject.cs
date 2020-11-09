using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public bool isObjectRotated;
    public void rotateObjectInOtherWay()
    {
        if (!isObjectRotated)
        {
            //  add global checker
            isObjectRotated = true;
            gameObject.transform.Rotate(0.0f, 180.0f, 0.0f);
            Debug.Log("Object now Rotated!");

        }
    }
}

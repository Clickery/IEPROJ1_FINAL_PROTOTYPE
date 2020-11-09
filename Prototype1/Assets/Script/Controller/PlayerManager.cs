using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public int keyCount;
    public int soulCount;
    public int objectPlacedCorrectly;
    public bool pickUpPlant = false;
    public bool pickUpStool = false;

    public bool placedPlant = false;
    public bool placedStool = false;
    public bool rotatedChair = false;
    public bool rotatedCouch = false;
    public bool tvBroken = false;

    public bool tutorialStageComplete = false;
    public bool stageOneComplete = false;

    void Start()
    {

    }
    void Update()
    {
        if (!tutorialStageComplete && soulCount >= 3)
        {
            tutorialStageComplete = true;
            SceneManager.LoadScene(6);
        }

        else if (!stageOneComplete && pickUpPlant && pickUpStool && placedPlant && placedStool && rotatedChair && rotatedCouch && tvBroken)
        {
            stageOneComplete = true;
            SceneManager.LoadScene(8);
        }
    }



    public void PickupKey()
    {
        keyCount++;
    }

    public void UseKey()
    {
        if (keyCount != 0)
        {
            keyCount--;
        }
        
       else
       {
           keyCount = 0;
       }
        soulCount++;
    }

    public void PickupPlant()
    {
        pickUpPlant = true;
    }

    public void PickupStool()
    {
        pickUpStool = true;
    }

    public void PlacedPlant()
    {
        placedPlant = true;
    }

    public void PlacedStable()
    {
        placedStool = true;
    }

    public void RotatedChair()
    {
        rotatedChair = true;
    }

    public void RotatedCouch()
    {
        rotatedCouch = true;
    }

    public void BreakTVSet()
    {
        tvBroken = true;
    }

    /*
    public void ObjectInRightPlace()
    {
        if ((pickUpPlant == true && placedPlant == false))
        {
            objectPlacedCorrectly++;
        }

        else if ((pickUpStool == true && placedStool == false))
        {
            objectPlacedCorrectly++;
        }

        else if ((rotatedChair == false))
        {
            objectPlacedCorrectly++;
        }

        else if ((rotatedCouch == false))
        {
            objectPlacedCorrectly++;
        }
     
        if ((tvBroken == false))
        {
            objectPlacedCorrectly++;
        }
    }*/
}

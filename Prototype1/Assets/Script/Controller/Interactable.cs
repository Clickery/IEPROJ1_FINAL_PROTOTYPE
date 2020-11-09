using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Interactable : MonoBehaviour
{
    public bool isInRange; // checks range if in or out of range
    public KeyCode interactKey; // key used for interaction
    public UnityEvent interactAction; // action to do when event happens

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(interactKey) && isInRange) // player presses interactKey & inrange is true
        {
            interactAction.Invoke(); // fire event
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player is in Range!");
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player is not in Range!");
        }
    }


    

}

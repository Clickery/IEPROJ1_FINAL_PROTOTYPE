using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpOBJDialog : MonoBehaviour
{
    public bool isOBJInInventory;
    public GameObject dialogBox;
    public Text dialogText;
    [TextArea(15, 20)] public string placeDialog;

    public bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            dialogBox.SetActive(false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            dialogBox.SetActive(false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dialogBox.SetActive(false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            dialogBox.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D others)
    {
        if (others.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player is in Range!");
        }
    }


    private void OnTriggerExit2D(Collider2D others)
    {
        if (others.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);
            Debug.Log("Player is not in Range!");
        }
        dialogBox.SetActive(false);
    }

    public void ChangePickUpOBJDialog()
    {
        if (!dialogBox.activeInHierarchy && !isOBJInInventory)
        {
            isOBJInInventory = true;
            dialogBox.SetActive(true);
            dialogText.text = placeDialog;
            Debug.Log("Key is now in Inventory...");
        }

        else if (dialogBox.activeInHierarchy && isOBJInInventory)
        {
            dialogBox.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateoObjectDialog : MonoBehaviour
{
    public bool rotatedPremanently;
    public GameObject dialogBox;
    public Text dialogText;
    [TextArea(15, 20)] public string objRotatedDialog;
    [TextArea(15, 20)] public string continueDialog;

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
    }

    public void RotateObjectDialog()
    {
        if (dialogBox.activeInHierarchy)
        {
            dialogBox.SetActive(false);
        }

        else if (!dialogBox.activeInHierarchy && !rotatedPremanently)
        {
            rotatedPremanently = true;
            dialogBox.SetActive(true);
            dialogText.text = objRotatedDialog;
            Debug.Log("Object is now in Rotated...");
        }

        else if (dialogBox.activeInHierarchy && rotatedPremanently)
        {
            dialogBox.SetActive(false);
        }
    }
}

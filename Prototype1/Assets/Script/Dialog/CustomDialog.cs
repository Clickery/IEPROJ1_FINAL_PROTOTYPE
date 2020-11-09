using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CustomDialog : MonoBehaviour
{
    public bool openedPremanently;
    public GameObject dialogBox;
    public Text dialogText;
    [TextArea(15, 20)] public string lockedDialog;
    [TextArea(15, 20)] public string unlockedDialog;

    public bool playerInRange;
    //private float timer = 1.0f;


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

    public void ChangeText(GameObject playerManager)
    {
        PlayerManager manager = playerManager.GetComponent<PlayerManager>();

        if (dialogBox.activeInHierarchy)
        {
            dialogBox.SetActive(false);
        }

        else if (!dialogBox.activeInHierarchy && manager.keyCount > 0 && !openedPremanently) // && player has a key and opened chest
        {
            openedPremanently = true;
            dialogBox.SetActive(true);
            dialogText.text = unlockedDialog;
        }

        else if (!dialogBox.activeInHierarchy && openedPremanently) // buggy shit
        {
            //dialogBox.SetActive(true);
            //dialogText.text = unlockedDialog;
        }

        else if (!dialogBox.activeInHierarchy && manager.keyCount == 0) // && player has no key to open chest
        {
            dialogBox.SetActive(true);
            dialogText.text = lockedDialog;
        }
    }
}

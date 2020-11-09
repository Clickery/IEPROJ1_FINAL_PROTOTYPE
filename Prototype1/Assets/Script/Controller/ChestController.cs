using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public bool isOpen;
    public Animator animator;
    public GameObject soulObj;
    public AudioClip soundEffect;

    public void OpenChest(GameObject obj) {
        PlayerManager manager = obj.GetComponent<PlayerManager>();

        if (!isOpen && manager.keyCount > 0)
        {
            isOpen = true;
            manager.UseKey();
            Debug.Log("Chest is now Open...");
            animator.SetBool("IsOpen", isOpen);
            AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            Destroy(soulObj);
        }

        else if (manager.keyCount <= 0 && !isOpen)
        {
            Debug.Log("Chest is LOCKED need a key to OPEN!");
        }
    }
}

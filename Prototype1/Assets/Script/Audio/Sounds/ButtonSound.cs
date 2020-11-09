using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource buttonFX;
    public AudioClip clickFX;

    public void ClickSound()
    {
        buttonFX.PlayOneShot(clickFX);
    }

}

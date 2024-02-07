using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrongButton : MonoBehaviour
{
    public AudioSource soundPlayer;
    // Start is called before the first frame update
    
    public void playThisSound()
    {
        Debug.Log("soiund player");
        soundPlayer.Play();
    }
}

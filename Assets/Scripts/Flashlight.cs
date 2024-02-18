using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashLight;
    public GameObject errorFlash;
    public ChicaHot chicaHotScript; // Reference to the ChicaHot script
    private bool isFlashlightActive = false; // Flag to control flashlight activation

    void Start()
    {
        // Find the GameObject with the ChicaHot script and get the script component
        chicaHotScript = GameObject.FindObjectOfType<ChicaHot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // Turn on the flashlight if space is pressed and chica is not moving
            if (!chicaHotScript.isMoving )
            {
                flashLight.SetActive(true);
                isFlashlightActive = true;
                Debug.Log("Flashlight on");
            }
        }
        else
        {
            // Turn off the flashlight if space is not pressed or chica is moving
            flashLight.SetActive(false);
            isFlashlightActive = false;

        }

        if (Input.GetKey(KeyCode.Space) && chicaHotScript.isMoving )
        {
            errorFlash.SetActive(true);
        }
        else
        {
            errorFlash.SetActive(false);
        }
    }
}
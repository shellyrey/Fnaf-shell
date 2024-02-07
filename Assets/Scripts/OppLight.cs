using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppLight : MonoBehaviour
{
    public GameObject chica3;
    public Light myLight;
    public Light flickerLight;
    public float minimumIntensity = 0f;
    public float maximumIntensity = 3f;// Reference to your light component

    // Update is called once per frame
    void Update()
    {
        if (chica3.activeSelf)
        {
            // If chica3 is active, set the light color to red
            myLight.color = Color.red;
           
            {
                flickerLight.intensity = Random.Range(minimumIntensity, maximumIntensity);
            }
        }
        else
        {
            // If chica3 is not active, you may want to set the light color to another color or do something else
            // For now, let's set it to white
            myLight.color = Color.white;
        }
    }
}

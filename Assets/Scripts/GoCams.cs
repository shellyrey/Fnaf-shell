using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class GoCams: MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject flipUp;
    public GameObject mainLight;
    public GameObject mainCam;
    public GameObject arcadeCam;
    public GameObject button;
    public GameObject button2;
    public GameObject cameraSystem;
    public GameObject cam4;

   
    
    public void start()
    {
        
    }
    
    // Define the action you want to perform when hovering over the button
    public void OnPointerEnter(PointerEventData eventData)
    {
        StartCoroutine(EnterCoroutine());
    }

    // Coroutine for waiting and performing actions
    IEnumerator EnterCoroutine()
    {
        flipUp.SetActive(true);
        mainLight.SetActive(false);
        

        // Wait for 0.15 seconds
        yield return new WaitForSeconds(0.30f);
        mainCam.SetActive(true);
        arcadeCam.SetActive(true);
        button.SetActive(false);
        button2.SetActive(true);
        cameraSystem.SetActive(true);

        

        


        // Perform additional actions here
        Debug.Log("Mouse over the button, waited for 0.15 seconds");
    }



    // Define the action you want to perform when the pointer exits the button
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse left the button");
        // Add your action here
    }
}
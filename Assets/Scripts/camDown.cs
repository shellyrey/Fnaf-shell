using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class camDown : MonoBehaviour, IPointerEnterHandler
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public GameObject cam6;
    public GameObject cam7;
    
    public GameObject mainLight;
    public GameObject camDownn;
    public GameObject camUp;
    public GameObject flipDown;
    public GameObject invis2;
    public GameObject flipUp;
    public GameObject cameraSystem; 
    public void OnPointerEnter (PointerEventData eventData)
    {
        StartCoroutine(EnterCoroutine());
   
    }
    IEnumerator EnterCoroutine()
    {
        cam2.SetActive(false);
        cam1.SetActive(true);
        cam3.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam7.SetActive(false);
     
        invis2.SetActive(true);
        flipUp.SetActive(false);
        flipDown.SetActive(true);
        cameraSystem.SetActive(false);

        yield return new WaitForSeconds(.15f);

        mainLight.SetActive(true);

        yield return new WaitForSeconds(0.30f);

        mainLight.SetActive(true);
       
        camDownn.SetActive(false);
        flipDown.SetActive(false);
        flipUp.SetActive(false);


    }
  
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCams : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public GameObject cam6;
    public GameObject maincam;
    public GameObject cam4blip;
    public GameObject cam5blip;
    public GameObject cam2blip;
    public GameObject cam1blip;
    public GameObject cam3blip;
    public GameObject cam6blip;

    public void goToCam4()
    {
        cam4.SetActive(true);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam4blip.SetActive(true);
        cam5blip.SetActive(false);
        cam2blip.SetActive(false);
        cam1blip.SetActive(false);
        cam3blip.SetActive(false);
        cam6blip.SetActive(false);


    }
    public void goToCam5()
    {
        cam4.SetActive(false);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam5.SetActive(true);
        cam6.SetActive(false);
        cam4blip.SetActive(false);
        cam5blip.SetActive(true);
        cam2blip.SetActive(false);
        cam1blip.SetActive(false);
        cam3blip.SetActive(false);
        cam6blip.SetActive(false);



    }
    public void goToCam2()
    {
        cam4.SetActive(false);
        cam1.SetActive(false);
        cam2.SetActive(true);
        cam3.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam4blip.SetActive(false);
        cam5blip.SetActive(false);
        cam2blip.SetActive(true);
        cam1blip.SetActive(false);
        cam3blip.SetActive(false);
        cam6blip.SetActive(false);
    }
    public void goToCam1()
    {
        cam4.SetActive(false);
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam4blip.SetActive(false);
        cam5blip.SetActive(false);
        cam2blip.SetActive(false);
        cam1blip.SetActive(true);
        cam3blip.SetActive(false);
        cam6blip.SetActive(false);
    }
    public void goToCam3()
    {
        cam4.SetActive(false);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(true);
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam4blip.SetActive(false);
        cam5blip.SetActive(false);
        cam2blip.SetActive(false);
        cam1blip.SetActive(false);
        cam3blip.SetActive(true);
        cam6blip.SetActive(false);
    }
    public void goToCam6()
    {
        cam4.SetActive(false);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(true);
        cam4blip.SetActive(false);
        cam5blip.SetActive(false);
        cam2blip.SetActive(false);
        cam1blip.SetActive(false);
        cam3blip.SetActive(false);
        cam6blip.SetActive(true);
    }
}

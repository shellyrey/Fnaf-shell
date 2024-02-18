using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChicaHot : MonoBehaviour
{
    public GameObject chica1;
    public GameObject chica2;
    public GameObject chica3;
    public GameObject chica4;
    public GameObject chica5;
    public GameObject chica6;
    public GameObject chica7;
    public GameObject chicaStart;
    public GameObject doorDown;
    public GameObject chicaScare;

    public GameObject deadText;
    public GameObject button;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public GameObject cam6;
    public GameObject mainCam;
    public GameObject camDown;
    public GameObject camsUI;

    public KeyCode targetKey = KeyCode.Space;

    public float chicaMove = 0f;
    public int chicaPosition = 0;
    public int chicaAI = 50;

    public int pressThreshold = 5;
    private int pressCount = 0;

    public bool chicaOne = false;
    public bool chicaTwo = false;
    public bool chicaThree = false;
    public bool chicaFour = false;
    public bool chicaFive = false;
    public bool chicaSix = false;
    public bool chicaSeven = false;
   
    public bool path1 = false;
    public bool path2 = false;
    private bool pathsChosen = false;
    public bool isMoving = false;
    

    

    

    public GameObject Static1;
    public GameObject Static2;
    public GameObject Static3;
    public GameObject Static4;
    public GameObject Static5;
    public GameObject Static6;

    

    // Update is called once per frame
    void Update()
    {
        chicaMove += 0.1f;

        

        //choosing what path
        if (!pathsChosen && chicaPosition == 0 && chicaMove >= 100)
        {
            int roll = Random.Range(1, 3);
            chicaMove = 0f;

            if (roll == 1)
            {
                path1 = true;
                path2 = false;
            }
            else
            {
                path1 = false;
                path2 = true;
            }

            pathsChosen = true;
        }

        {
           

            // Check if yourBool is true
            if (isMoving)
            {
                // Activate the object
                Static1.SetActive(true);
                Static2.SetActive(true);
                Static3.SetActive(true);
                Static4.SetActive(true);
                Static5.SetActive(true);
                Static6.SetActive(true);
            }
            
            {
                // Deactivate the object
                Static1.SetActive(false);
                Static2.SetActive(false);
                Static3.SetActive(false);
                Static4.SetActive(false);
                Static5.SetActive(false);
                Static6.SetActive(false);
            }
        }

         


        // path 1
        if (chicaPosition == 0 && chicaMove >= 100 && path1)
        {
            int roll = Random.Range(1, 101);
            chicaMove = 0f;

            if (roll <= chicaAI)
            {
                chica1.SetActive(true);
                chica2.SetActive(false);
                chica3.SetActive(false);
                chica4.SetActive(false);
                chica5.SetActive(false);
                chica6.SetActive(false);
                chica7.SetActive(false);
                chicaStart.SetActive(false);
                
                chicaPosition = 1;

                chicaOne = true;
                chicaTwo = false;
                chicaThree = false;
                chicaFour = false;
                chicaFive = false;
                chicaSix = false;
                chicaSeven = false;
               

                StartCoroutine(ChicaMoving());

                

            }
        }

        // path 2
        if (chicaPosition == 0 && chicaMove >= 100 && path2)
        {
            int roll = Random.Range(1, 101);
            chicaMove = 0f;

            if (roll <= chicaAI)
            {
                chica1.SetActive(false);
                chica2.SetActive(false);
                chica3.SetActive(false);
                chica6.SetActive(true);
                chica4.SetActive(false);
                chica5.SetActive(false);
                chica7.SetActive(false);
                chicaStart.SetActive(false);
                
                chicaPosition = 6;

                chicaOne = false;
                chicaTwo = false;
                chicaThree = false;
                chicaFour = false;
                chicaFive = false;
                chicaSix = true;
                chicaSeven = false;
               

                StartCoroutine(ChicaMoving());
            }
        }

        // path 2 part 2
        if (chicaPosition == 6 && chicaMove >= 100)
        {
            int roll = Random.Range(1, 101);
            chicaMove = 0f;

            if (roll <= chicaAI)
            {
                chica1.SetActive(false);
                chica2.SetActive(false);
                chica3.SetActive(false);
                chica6.SetActive(false);
                chica4.SetActive(false);
                chica5.SetActive(false);
                chica7.SetActive(true);
                chicaStart.SetActive(false);
                

                chicaPosition = 7;

                chicaOne = false;
                chicaTwo = false;
                chicaThree = false;
                chicaFour = false;
                chicaFive = false;
                chicaSix = false;
                chicaSeven = true;
                
                StartCoroutine(ChicaMoving());
            }
        }

        // path 2 part 3 (meets with path 1)
        if (chicaPosition == 7 && chicaMove >= 100)
        {
            int roll = Random.Range(1, 101);
            chicaMove = 0f;

            if (roll <= chicaAI)
            {
                chica1.SetActive(false);
                chica2.SetActive(false);
                chica3.SetActive(true);
                chica6.SetActive(false);
                chica4.SetActive(false);
                chica5.SetActive(false);
                chica7.SetActive(false);
                chicaStart.SetActive(false);
                

                chicaPosition = 3;

                chicaOne = false;
                chicaTwo = false;
                chicaThree = true;
                chicaFour = false;
                chicaFive = false;
                chicaSix = false;
                chicaSeven = false;
               

                StartCoroutine(ChicaMoving());
            }
        }

        // path 1 part 2
        if (chicaPosition == 1 && chicaMove >= 100)
        {
            int roll = Random.Range(1, 101);
            chicaMove = 0f;

            if (roll <= chicaAI)
            {
                chica1.SetActive(false);
                chica2.SetActive(true);
                chica3.SetActive(false);
                chica6.SetActive(false);
                chica4.SetActive(false);
                chica5.SetActive(false);
                chica7.SetActive(false);
                chicaStart.SetActive(false);
               
                chicaPosition = 2;

                chicaOne = false;
                chicaTwo = true;
                chicaThree = false;
                chicaFour = false;
                chicaFive = false;
                chicaSix = false;
                chicaSeven = false;
                

                StartCoroutine(ChicaMoving());
            }
        }

        // Repeat similar blocks for other chica positions...

        if (chicaPosition == 2 && chicaMove >= 100)
        {
            int roll = Random.Range(1, 101);
            chicaMove = 0f;

            if (roll <= chicaAI)
            {
                chica1.SetActive(false);
                chica2.SetActive(false);
                chica3.SetActive(true);
                chica6.SetActive(false);
                chica4.SetActive(false);
                chica5.SetActive(false);
                chica7.SetActive(false);


                chicaPosition = 3;

                chicaOne = false;
                chicaTwo = false;
                chicaThree = true;
                chicaFour = false;
                chicaFive = false;
                chicaSix = false;
                chicaSeven = false;
             

                StartCoroutine(ChicaMoving());
            }
        }

        if (chicaPosition == 3 && chicaMove >= 100)
        {
            int roll = Random.Range(1, 101);
            chicaMove = 0f;

            if (roll <= chicaAI)
            {
                chica1.SetActive(false);
                chica2.SetActive(false);
                chica3.SetActive(false);
                chica6.SetActive(false);
                chica4.SetActive(true);
                chica5.SetActive(false);
                chica7.SetActive(false);


                chicaPosition = 4;

                chicaOne = false;
                chicaTwo = false;
                chicaThree = false;
                chicaFour = true;
                chicaFive = false;
                chicaSix = false;
                chicaSeven = false;
                

                StartCoroutine(ChicaMoving());
            }
        }

        if (chicaPosition == 4 && chicaMove >= 100)
        {
            int roll = Random.Range(1, 101);
            chicaMove = 0f;

            if (roll <= chicaAI)
            {
                chica1.SetActive(false);
                chica2.SetActive(false);
                chica3.SetActive(false);
                chica4.SetActive(false);
                chica5.SetActive(true);
                

                chicaPosition = 5;

                chicaOne = false;
                chicaTwo = false;
                chicaThree = false;
                chicaFour = false;
                chicaFive = true;
                chicaSix = false;
                chicaSeven = false;
                

                StartCoroutine(ChicaMoving());
            }
        }

        // Additional checks...

        if (Input.GetKeyUp(targetKey) && chicaFour)
        {
            pressCount++;

            if (pressCount >= pressThreshold)
            {
                ResetChicas();
            }
        }

        if (doorDown.activeInHierarchy && chicaFive)
        {
            StartCoroutine(DeactivateChicasAfterDelay(2.0f));
        }

        if (chicaPosition == 5 && chicaMove >= 100)
        {
            chica1.SetActive(false);
            chica2.SetActive(false);
            chica3.SetActive(false);
            chica4.SetActive(false);
            chica5.SetActive(false);
            chicaScare.SetActive(true);
            deadText.SetActive(true);
            button.SetActive(false);
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            mainCam.SetActive(true);
            camDown.SetActive(false);
            camsUI.SetActive(false);

            StartCoroutine(SendToMenuAfterScare(5f));
        }
    }

    private IEnumerator SendToMenuAfterScare(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("MainMenu");
    }

    private IEnumerator DeactivateChicasAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        ResetChicas();
    }
    private IEnumerator ChicaMoving()
    {
        isMoving = true; // Set the bool to true when the timer starts

        yield return new WaitForSeconds(1f); // Wait for 2 seconds

        isMoving = false; // Set the bool to false after 2 seconds
    }

    private void ResetChicas()
    {

        StartCoroutine(ChicaMoving());
        chica1.SetActive(false);
        chica2.SetActive(false);
        chica3.SetActive(false);
        chica4.SetActive(false);
        chica5.SetActive(false);
        chicaStart.SetActive(true);
        pathsChosen = false;
        chicaMove = 0f;
        chicaPosition = 0;
        pressCount = 0;



        
    }
    

}

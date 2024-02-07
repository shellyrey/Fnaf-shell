using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
    public string targetSceneName = "SampleScene";
    
   
        public void LoadSceneOnClick()
        {
            SceneManager.LoadScene(targetSceneName);
        }
    public void QuitGame()
    {
        Debug.Log("quit game");
        Application.Quit();
     
    }
}

    



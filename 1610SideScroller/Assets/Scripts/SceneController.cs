using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public int LoadScene;

    public void LoadLevel()
    {
        SceneManager.LoadScene(LoadScene);
    }
    
    public void ExitLevel()
    {
        Application.Quit();
    }
    
    //borrowed from Sophomore
}
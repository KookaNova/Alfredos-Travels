using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public UnityEvent EscKeyPressed;
    
    public int LoadScene;

    public void LoadLevel()
    {
        SceneManager.LoadScene(LoadScene);
    }
    
    public void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscKeyPressed.Invoke();
        }
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
    
    //borrowed from Sophomore
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    bool isPaused;

    

    void Start()
    {
        isPaused = false;
    }

    public void Toggle()
    {
        if (!isPaused)
        {
            pauseMenu.SetActive(true);
            isPaused = true;
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else 
        {
            Resume();
        }
    }
    public void Resume()
    {
           pauseMenu.SetActive(false);
           isPaused = false;
           Time.timeScale = 1;
           Cursor.visible = false;
           Cursor.lockState = CursorLockMode.Locked;
    }
    public void GotoMenu(string name) 
    {
       // SceneManager.LoadScene(name);
    }
    public void QuitGame() 
    {
        Application.Quit();
    }
}

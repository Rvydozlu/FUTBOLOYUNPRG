using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Esctusu : MonoBehaviour
{
   private bool isPaused = false;
   public GameObject pausePanel;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }
  


   

    public void Restart()
    {
        // Resume düğmesi ekranını kapatmak için
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause()
    {
        
        
        // Resume düğmesi ekranını açmak için
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
    {
         Time.timeScale = 1f;
         SceneManager.LoadScene("SampleScene");
         isPaused = false;
    }

    public void MenuDon()
    {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1f;
}
}


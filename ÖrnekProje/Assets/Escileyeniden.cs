using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escileyeniden : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                //oyunu devam ettirme
                Time.timeScale = 1.0f;
                isPaused = false;
            }
            else
            {
                //oyunu durdurma
                Time.timeScale = 0.0f;
                isPaused = true;
            }
        }
    }
}
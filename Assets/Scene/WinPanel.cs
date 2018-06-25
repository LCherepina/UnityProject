using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanel : MonoBehaviour {

    public static bool GameIsEnded = false;
    public GameObject pauseMenuUI;
    public GameObject pauseMenuUIBackground;

    // Update is called once per frame
    void Update()
    {
     //   if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsEnded)
                Resume();
            else
                Pause();
        }
    }
    public void Retry()
    {
        pauseMenuUI.SetActive(false);
        pauseMenuUIBackground.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void NextLevel()
    {
        pauseMenuUI.SetActive(true);
        pauseMenuUIBackground.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

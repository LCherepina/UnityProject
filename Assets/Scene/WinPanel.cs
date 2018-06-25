using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPanel : MonoBehaviour {

    public static bool GameIsEnded = false;
    public GameObject pauseMenuUI;
    public string retrylevel;
    public string menu;

    void Update()
    {
        //pauseMenuUI.SetActive(true);
    }
    public void Retry()
    {
        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene(retrylevel);
    }
    public void NextLevel()
    {
        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene(menu);
    }
}

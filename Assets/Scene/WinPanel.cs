using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPanel : MonoBehaviour {

    public GameObject pauseMenuUI;
    public string retrylevel;
    public string menu;

    void Start()
    {

    }
    void Update()
    {   }
    public void Retry()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(retrylevel);
    }
    public void NextLevel()
    {
    
        Time.timeScale = 1f;
        SceneManager.LoadScene(menu);
    }
}

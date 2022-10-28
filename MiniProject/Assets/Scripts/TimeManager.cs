using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    //void Start()
    //{
    //    Time.timeScale = 10f;
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}

    public float timeRemaining = 10;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if(timeRemaining <= 0)
            {
                LoadNextScene();
            }
        }
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    //public void LoadStartScene()
    //{
    //    SceneManager.LoadScene(0);
    //}
    //public void QuitGame()
    //{
    //    Application.Quit();
    //}
}
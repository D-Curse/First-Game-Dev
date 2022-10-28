using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public string[] sceneNames;

    public void QuitGame()
    {
        Debug.Log("Quitted");
        Application.Quit();
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadPreviousScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex - 1);
    }

    public void LoadScene()
    {
        string sceneName = sceneNames[Random.Range(0,sceneNames.Length)];
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}

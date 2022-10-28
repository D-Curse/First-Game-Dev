using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{

    private int indexNo;
    private float Instance = 0;

    void Start()
    {
        indexNo = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Copied Index Number...");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Instance == 0)
            {
                DontDestroyOnLoad(this.gameObject);
                Debug.Log("Loaded Menu");
                UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
                Instance = 1;
            }
            else if(Instance == 1)
            {
                Debug.Log("Resumed");
                UnityEngine.SceneManagement.SceneManager.LoadScene(indexNo);
                Destroy(this.gameObject);
            }
        }

    }
}
    /*void OnDestroy()
    {
        Debug.Log("OnDestory Started");
        DontDestroyOnLoad(this.gameObject);
        Instance = 0;
    }*/
       /* if (Input.GetKeyDown(KeyCode.Escape))
        {
            //SceneManager.GetActiveScene().buildIndex;
            Debug.Log("Escaped!!!");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
            Instance = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Return to previous scene");
            UnityEngine.SceneManagement.SceneManager.LoadScene(indexNo);
            Instance = 0;
        }
        if (Instance == 1)
        {
            DontDestroyOnLoad(this.gameObject);
            Debug.Log("Not Destroyed!!!");
        }




    void Awake()
    {
        else if (Instance == 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Destroyed the gameobject");
    }
        }*/

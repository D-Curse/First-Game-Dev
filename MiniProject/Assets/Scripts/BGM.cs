using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioListener))]
[RequireComponent(typeof(AudioSource))]

public class BGM : MonoBehaviour
{

    private static BGM instance = null;
    public static BGM Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (BGM)FindObjectOfType(typeof(BGM));
            }
            return instance;
        }
    }
     
    void Awake ()
    {
        if (Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void MuteToggle(bool muted)
    {  
        if (muted)
       {
             GetComponent<AudioSource>().Play();
        }
        else 
        {
            GetComponent<AudioSource>().Pause();
        }
    }

}

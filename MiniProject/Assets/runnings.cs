using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runnings : MonoBehaviour

{
    public AudioSource runningsSound;

    void Update()
    {
                     if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) {
                      runningsSound.enabled = true ;
                     }
                    else
                    {
                     runningsSound.enabled = false ;
                     }
    }
}


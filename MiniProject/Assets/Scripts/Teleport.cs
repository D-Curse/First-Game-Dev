using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
 /*   private GameObject currentTeleporter;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(currentTeleport != null)
            {
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
            }
        }
    }

    private void OnTriggeredEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
    }

    private void OnTriggeredExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Teleporter"))
        {
            if(collision.gameObject == currentTeleporter)
            {
                currentTeleporter == null;
            }
        }
    }*/
}


    /*public GameObject portal;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        Debug.Log("starting tp");
    }

    void OnTriggeredEnter(Collider2D coll)
    {
        if(coll.name == "Player")
        {
            Debug.Log("TELEPORT");
            player.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        }
    }
    */
 //   public Transform teleportTarget;
   // public GameObject thePlayer;

/*
    void OnCollide(Collider coll)
    {
        if(coll.name == "Player")
        {
        thePlayer.transform.position = teleportTarget.transform.position;
        }
    }


    void OnCollide(Collider2D coll)
    {
        if(coll.name == "thePlayer")
        {
            Debug.Log("Teleported");
            thePlayer.transform.position = teleportTarget.transform.position;   
        }
    }

    private int Dead = 1;

    protected void OnCollide(Collider2D coll)
    {
        if(coll.name == "Player")
        {
            Dead = 0;
        }
    }
    void LateUpdate()
    {
        if(Dead == 0)
        {
            Debug.Log("Teleport");
            Dead = 1;
        }

    }


    //public string[] sceneNames;
    public Vector3 TempPosition;
    
    protected override void OnCollide(Collider2D coll)
    {
        if(coll.name == "Player")
        {
            TempPosition = player.transform.position;
        }
    }


    private void OnCollide(Collider2D coll)
    {
        if(coll.name == "Player")
        {
            Debug.Log("Teleport");
            //transform.position = new Vector2(transform.position.x,transform.position.y);
        }
    }
    */
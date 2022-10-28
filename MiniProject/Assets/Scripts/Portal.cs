using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : Collider
{
    public string[] sceneNames;
    //public Vector3 TempPosition;
    
    protected override void OnCollide(Collider2D coll)
    {
        if(coll.name == "Player")
        {
            //TempPosition = player.transform.position;
            //Teleport the player
            string sceneName = sceneNames[Random.Range(0,sceneNames.Length)];
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}
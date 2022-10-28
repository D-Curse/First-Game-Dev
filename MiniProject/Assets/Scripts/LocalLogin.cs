using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
 
 public class LocalLogin : MonoBehaviour
 {
     [Header("Local Login")]
     public InputField username_textBox;
     private int usersCount;
     private string[] userNames;
 
     public void Start()
     {
         // Retrieve the number of registered users.
         usersCount = PlayerPrefs.GetInt("UsersCount", 0);
         if (usersCount > 0)
         {
             // Create the user name array...
             userNames = new string[usersCount];
             for (int index = 0; index < usersCount; index++)
             {
                 //...and load them.
                 userNames[index] = PlayerPrefs.GetString("User" + index, string.Empty);
             }
         }
     }
 
     // This reads from PlayerPrefs the LAST registered user ONLY.   

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
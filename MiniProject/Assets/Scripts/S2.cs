using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S2 : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    
   // string vol;

    void Start()
    {
        //saveData();
        SoundManager.Instance.ChangeVolume(_slider.value);
        _slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeVolume(val));
  //      if(PlayerPrefs.HasKey("AudioToggle")) 
  //      {
  //      AudioListener.volume = (PlayerPrefs.GetInt("AudioToggle", 1) == 1) ? 1.0f : 0.0f;
  //      }  
  //      else
  //      {
  //          AudioListener.volume = 1.0f;
  //          PlayerPrefs.SetInt ("AudioToggle", 1);
///          PlayerPrefs.Save();
///      }
     }
//
// public void saveData()
// {
//     if(PlayerPrefs.HasKey(vol))
//     {
//         _slider.value = PlayerPrefs.GetFloat("vol");
//         PlayerPrefs.Save();
//         Debug.Log("ADDED VALUE!!!");
//     }
//     else if(_slider.val>0)
//     {
//         PlayerPrefs.SetFloat("vol", _slider.value);
//         PlayerPrefs.Save();
//         Debug.Log("SAVED");
//     }
// }
}
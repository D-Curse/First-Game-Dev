using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] private  AudioSource _musicSource, _effectsSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Playsound(AudioClip clip)
    {
        _effectsSource.PlayOneShot(clip);
    }

    public void ChangeVolume(float value)
    {
        AudioListener.volume = value;
    }
}
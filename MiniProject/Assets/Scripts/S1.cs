using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class S1 : MonoBehaviour
{
   [SerializeField] private Slider _slider;
   [SerializeField] private TextMeshProUGUI _sliderText;

    const string VolumeLvl = "VolumeLevel";

   void Start()
   {
        _slider.onValueChanged.AddListener((v) => {
            _sliderText.text = v.ToString("0");
        });
   } 
}
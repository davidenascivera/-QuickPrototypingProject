using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SliderNumero : MonoBehaviour
{
   [SerializeField] private Slider _slider;
   [SerializeField] private TextMeshProUGUI _sliderText;

    void Start()
    {
        _slider.onValueChanged.AddListener((v) => {
            _sliderText.text = v.ToString("0");
        });
    }

}

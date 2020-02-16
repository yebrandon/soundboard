using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ExtraFeatures : MonoBehaviour
{
    public Slider doppler;

    public AudioSource musicSource;

    public AudioMixerSnapshot echo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (doppler.value == 2)
        {
            echo.TransitionTo(.01f);
        }
    }

}

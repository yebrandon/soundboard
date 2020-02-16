using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class slider_Mega : MonoBehaviour
{
    public Slider memeSound;

    public Slider volume;

    public Slider doppler;

    public AudioSource musicSource;

    public Button song;

    private bool playing = false;

    public AudioMixerSnapshot boost;
    public AudioMixerSnapshot normal;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = song.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        musicSource.pitch = memeSound.value;

        musicSource.volume = volume.value;

        if (doppler.value == 0)
        {
            normal.TransitionTo(.01f);
        }
        if(doppler.value == 1)
        {
            boost.TransitionTo(.01f);
        }

        
    }
    void TaskOnClick()
    {
        if (playing)
        {
            musicSource.Pause();
            playing = false;
        }
        else
        {
            musicSource.Play();
            playing = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumecontrol : MonoBehaviour
{
    
    private AudioSource audioSrc;
    public Slider musicSlider;
    

    
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        musicSlider.value = PlayerPrefs.GetFloat("Music", 1f);
    }
    void Update()
    {
        audioSrc.volume = PlayerPrefs.GetFloat("Music");
    }
    public void SetVolume(float vol)
    {
        PlayerPrefs.SetFloat("Music", vol);  
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumecontrol : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSrc;
    public Slider musicSlider;
    // Music volume variable that will be modified
    // by dragging slider knob
    
    

    // Use this for initialization
    void Start()
    {

        // Assign Audio Source component to control it
        audioSrc = GetComponent<AudioSource>();
        musicSlider.value = PlayerPrefs.GetFloat("Music", 1f);
    }

    // Update is called once per frame
    void Update()
    {

        // Setting volume option of Audio Source to be equal to musicVolume
        audioSrc.volume = PlayerPrefs.GetFloat("Music");
    }

    // Method that is called by slider game object
    // This method takes vol value passed by slider
    // and sets it as musicValue
    public void SetVolume(float vol)
    {
        PlayerPrefs.SetFloat("Music", vol);
        
    }
}
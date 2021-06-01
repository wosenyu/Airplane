using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumechanger : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource AudioSource;
    public GameObject objectMusic;

    private float musicVolume = 0.1f;

    void Start(){
        objectMusic = GameObject.FindWithTag("GameMusic");
        AudioSource = objectMusic.GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume;
    }

    public void updateVolume(float volume){
        musicVolume = volume;
    }
}

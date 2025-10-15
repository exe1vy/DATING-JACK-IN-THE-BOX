
using UnityEngine;
using System.Collections.Generic;


public class script : MonoBehaviour
{
    public AudioSource bgMusic;
    public AudioSource funnySounds;
    public List<AudioClip> soundEffects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        funnySounds.clip = soundEffects[Random.Range(0,9)];
        funnySounds.Play();
        //bgMusic.Play();
    }
    
}

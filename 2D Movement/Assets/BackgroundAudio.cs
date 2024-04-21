using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class BackgroundAudio : MonoBehaviour
{
    public AudioClip backgroundMusic; 
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = backgroundMusic;

        audioSource.loop = true;

        audioSource.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource source;
    public AudioClip SonidoSalto;
    public AudioClip SonidoEmpieza;
    public AudioClip SonidoDisparo;
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = SonidoEmpieza;
        source.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            source.clip = SonidoSalto;
            source.Play();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            source.clip = SonidoDisparo;
            source.Play();
        }
    }
} 
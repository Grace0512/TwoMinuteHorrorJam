using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class HorrorSounds : HorroObject
{
    private AudioSource aud;
    [Header("音效")]
    public AudioClip sound;
    [Header("音量"),Range(0.1f,10)]
    public float volume = 1;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }
    public override void TriggerEvent()
    {
        aud.PlayOneShot(sound, volume);
    }
}

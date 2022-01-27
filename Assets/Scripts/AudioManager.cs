using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public Sound[] meows;

    public static AudioManager instance;

    private GameObject glm;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.loop = s.loop;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
        foreach (Sound s in meows)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.loop = s.loop;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    private void Start()
    {
        glm = GameObject.Find("GameLogicManager");
        Play("Menu");
    }

    private void Update()
    {
        if (glm.GetComponent<GameLogicManager>().endConMet && glm.GetComponent<GameLogicManager>().isWin)
        {
            PlayOneShot("StageComplete");
        }
        if (glm.GetComponent<GameLogicManager>().endConMet && !glm.GetComponent<GameLogicManager>().isWin)
        {
            PlayOneShot("Gameover");
        }

    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null || s.source.isPlaying)
        {
            return;
        }
        s.source.Play();
    }

    public void PlayOneShot(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null || s.source.isPlaying)
        {
            return;
        }
        s.source.PlayOneShot(s.source.clip);
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
        s.source.Stop();
    }

    public void Pitch(string name, float pitch)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
        s.source.pitch = pitch;
    }

    public void Volume(string name, float vol)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
        s.source.volume = vol;
    }

    public void PlayNya()
    {
        Sound s = meows[UnityEngine.Random.Range(0, meows.Length)];
        if (s == null || s.source.isPlaying)
        {
            return;
        }
        s.source.volume = 0.9f;
        s.source.PlayOneShot(s.source.clip);
    }

}

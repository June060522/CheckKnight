using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectAudio : MonoBehaviour
{
    public Slider EffVolume;
    public AudioSource _audio;

    private float effVol = 1f;

    public static EffectAudio Instance;
    void Awake()
    {
        EffectAudio.Instance = this;
    }
    void Start()
    {
        effVol = PlayerPrefs.GetFloat("effvol", 1f);
        EffVolume.value = effVol;
        if(_audio != null)
            _audio.volume = EffVolume.value;

    }

    void Update()
    {
        if (_audio != null)
            _audio.volume = EffVolume.value;

        effVol = EffVolume.value;
        PlayerPrefs.SetFloat("effvol", effVol);
    }

    public void ListenEff(AudioClip a)
    {
        _audio.clip = a;
        _audio.Play();
    }

    public void Stop()
    {
        _audio.Stop();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchTime : MonoBehaviour
{
    public AudioClip wicthClip;
    public float timeScale;
    public float volume;
    AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            AudioSource src = AudioManager.instance.PlayAudio(wicthClip, "wicthSound");
            StartCoroutine(PlayAudio(src));
        }
        
       
    }
    IEnumerator PlayAudio(AudioSource wicthClip)
    {
            Time.timeScale = 0.25f;
        while (wicthClip && wicthClip.isPlaying)
        {
            yield return null;
        }

        Time.timeScale = 1f;
    }
      
}




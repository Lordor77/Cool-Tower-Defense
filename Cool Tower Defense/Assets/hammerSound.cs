using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class hammerSound : MonoBehaviour {

    public AudioClip MusicClip;
    public AudioSource MusicSource;


    // Use this for initialization
    void Start () {
        GetComponent<AudioSource>().Play();
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update () {
		
	}
    void playSound()
    {

        MusicSource.Play();

    }
}

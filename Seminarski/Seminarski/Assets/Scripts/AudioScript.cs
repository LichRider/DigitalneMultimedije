using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioScript : MonoBehaviour {

    private AudioSource source;
	// Use this for initialization
	void Awake () {
        source = GetComponent<AudioSource>();
	}
	
    public void GetCoin()
    {
        source.Play();
    }
	// Update is called once per frame
	void Update () {
		
	}
}

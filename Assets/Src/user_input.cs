using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class user_input : MonoBehaviour {
	public GameObject fired_beam_prefab;
	private float StartTime;
	public float LifeTime = 1f;
	private GameObject fired_beam;
	public AudioSource audioSource;
	public float updateEvery = 0.25f;
	public float updateTracker;
	private float[] clipSample;
	public float clipVolume;
	public float sampleLength;
	// Use this for initialization


	void Start () {
		StartTime = Time.time;
		fired_beam = Instantiate(fired_beam_prefab);
		fired_beam.SetActive(false);
		audioSource.clip = Microphone.Start(null, true, 1, AudioSettings.outputSampleRate);
	}
	// Update is called once per frame
	void Update () {
		updateTracker += Time.deltaTime;
            if (updateTracker >= updateEvery) {
			clipSample = new float[audioSource.clip.samples * audioSource.clip.channels];       //create/reset float array
			audioSource.clip.GetData(clipSample, audioSource.timeSamples);                      //fill float array with samples from audio
			clipVolume = 1f;                                                                    //reset the final outputted volume
		foreach (var sample in clipSample) {
    			clipVolume += Mathf.Abs(sample);                                               //Find the average volume
			}
			clipVolume /= sampleLength;
		}

		if (Time.time >= StartTime + LifeTime) {
			if (clipVolume > 1.5) {
				fired_beam.SetActive(true);
				fired_beam.transform.position = transform.position;
				StartTime = Time.time;
			} else {
                 		// the bullet is set to inactive, so it vanishes.
				// github chris
                 		fired_beam.SetActive(false);
	     		}
       	}
	}
}

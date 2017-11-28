using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;		//	Required to handle scenes

public class MusicManager : MonoBehaviour {

	//	Public properties
	public AudioClip[] levelMusicChangeArray;		//	Array of songs to play on each scene

	//	Private properties
	private AudioSource audioSource;

	//	We tell our game to not destory the music object
	void Awake () {
		DontDestroyOnLoad (gameObject);
	}

	// Use this for initialization
	void Start () {
		SceneManager.sceneLoaded += this.OnceLevelWasLoaded;
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//	This method handles the sceneLoaded event.
	void OnceLevelWasLoaded(Scene scene, LoadSceneMode sceneMode) {
		//	We retrieve this level's clip
		AudioClip thisLevelMusic = levelMusicChangeArray[scene.buildIndex];

		//	If there really is an audio clip assigned to this level, then we assign it to
		//	our audio source and then we start playing it in a loop.
		if (thisLevelMusic) {
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}

	public void SetVolume(float volume) {
		audioSource.volume = volume;
	}
}

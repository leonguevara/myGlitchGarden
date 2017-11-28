using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeFX : MonoBehaviour {

	public float fadeInTime;					//	fade in time, in seconds

	private Image fadePanel;					//	to handle the panel
	private Color currentColour = Color.black;	//	

	// Use this for initialization
	void Start () {
		//	We get the Image component of our panel so we can change its color/alpha properties
		fadePanel = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < fadeInTime) {
			float alphaChange = Time.deltaTime / fadeInTime;
			currentColour.a -= alphaChange;
			fadePanel.color = currentColour;
		} else {
			gameObject.SetActive(false);
		}
	}
}

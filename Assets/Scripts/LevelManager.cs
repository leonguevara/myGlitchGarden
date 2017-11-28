using UnityEngine;
using UnityEngine.SceneManagement;		// Requiered to switch scenes
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;

	//	It will help us move to the next level after the specified number of seconds.
	void Start() {
		//	if our autoLoadNextLevelAfter is not 0, then we load the next level after the
		//	autoLoadNexLevelAfter amount of seconds.
		if (autoLoadNextLevelAfter != 0) {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

	//	This method allow us to move to a given scene
	public void LoadLevel(string name){
		//	Debug.Log ("New Level load: " + name);	//
		//	Application.LoadLevel (name);    // This method was deprecated a long time ago
		SceneManager.LoadScene (name);
	}

	//	This method terminates the application (game)
	public void QuitRequest(){
		//	Debug.Log ("Quit requested");
		Application.Quit ();
	}

	//	This method load the next level according to the build settings
	public void LoadNextLevel() {
		SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex + 1);
	}
}

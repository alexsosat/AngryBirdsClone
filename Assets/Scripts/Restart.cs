using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	private Scene scene;
	void Start () {
		scene = SceneManager.GetActiveScene();
	}
	
	void OnMouseDown(){
		SceneManager.LoadScene (scene.name);
	}
}

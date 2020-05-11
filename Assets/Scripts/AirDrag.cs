using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDrag : MonoBehaviour {

	[SerializeField] public GameObject icon;
	[SerializeField] public GameObject bird;


	int counter =0;
	 Rigidbody2D ld;


	void Start(){
		Bird.maxVel = 15f;
		ld = bird.GetComponent<Rigidbody2D> ();

	}
		

	void OnMouseDown(){

		if (counter == 0) {
			icon.SetActive (true);
			gameObject.SetActive (false);
			Bird.maxVel = 23f;
			ld.drag = 0.9f;
			counter++;


		} else {
			icon.SetActive (false);
			gameObject.SetActive (true);
			Bird.maxVel = 15f;
			ld.drag = 0;
			counter--;

		}
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	public float Ressitance;
	public GameObject explosion;

	void OnCollisionEnter2D(Collision2D col){
		if (col.relativeVelocity.magnitude > Ressitance) {
			Destroy (gameObject, 0.1f);
			if (explosion != null) {
				var go = Instantiate (explosion, transform.position, Quaternion.identity);
				Destroy (go, 3);
			}
		} else {
			Ressitance  -= col.relativeVelocity.magnitude;
		}
	}
}

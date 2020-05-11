using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour {

	[SerializeField] public GameObject bird;
	Rigidbody2D rigid;
	Vector2 velocity;
	double speed;
	Text text;


	void Start () {
		rigid = bird.GetComponent<Rigidbody2D> ();
		text = GetComponent<Text>();
	}
	

	void Update () {
		velocity = rigid.velocity;
		speed = velocity.magnitude;
		text.text = speed.ToString("F2");
	}
}

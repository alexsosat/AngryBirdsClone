using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Angle : MonoBehaviour {

	/*public Transform target;
	public Transform form;
	private float angle;*/
	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		/*if (!target)
			return;

		var myPos = form.position;
		myPos.z = 0;

		var targetPos = target.position;
		targetPos.z = 0;

		Vector3 toOther = (myPos - targetPos).normalized;

		angle = Mathf.Atan2 (toOther.y, toOther.x) * Mathf.Rad2Deg + 180;*/

		text.text = Bird.angle.ToString("F2");

	}
}

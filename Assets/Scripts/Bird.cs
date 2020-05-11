using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Bird : MonoBehaviour {
	public Transform pivot;
	public float springRange;
	public static float maxVel;

	public Transform target;
	public Transform form;
	public static float angle;

	Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.bodyType = RigidbodyType2D.Kinematic;
	}

	bool canDrag = true;
	Vector3 dis;

	void OnMouseDrag(){
		if (!canDrag)
			return;
		
		var pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		dis = pos - pivot.position;
		dis.z = 0;
		if (dis.magnitude > springRange) {
			dis = dis.normalized * springRange;
		}
		transform.position = dis + pivot.position;

		if (!target)
			return;

		var myPos = form.position;
		myPos.z = 0;

		var targetPos = target.position;
		targetPos.z = 0;

		Vector3 toOther = (myPos - targetPos).normalized;

		angle = Mathf.Atan2 (toOther.y, toOther.x) * Mathf.Rad2Deg + 180;
	}

	void OnMouseUp(){
		if (!canDrag)
			return;
		canDrag = false;
		rb.bodyType = RigidbodyType2D.Dynamic;
		rb.velocity = -dis.normalized * maxVel * dis.magnitude/springRange;
	}
}

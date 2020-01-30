using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapControl : MonoBehaviour {

	private Vector2 st_pos;
	private Vector2 next_pos;
	private Vector2 force;

	public Rigidbody2D rb;
	private float maxForce = 200f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		st_pos = Input.mousePosition;
	}

	void OnMouseUp(){
		if (rb.velocity.y == 0) {
			rb.constraints = RigidbodyConstraints2D.None;
			next_pos = Input.mousePosition;
			// Force and Mouse restraints
			force = st_pos - next_pos;
			if (Mathf.Abs(force [0]) >= maxForce) {
				if (force [0] < 0) {
					force [0] = -maxForce;
				} else {
					force [0] = maxForce;
				}
			}
			if (Mathf.Abs(force [1]) >= maxForce) {
				if (force [1] < 0) {
					force [1] = -maxForce;
				} else {
					force [1] = maxForce;
				}
			}
			Debug.Log (force);
			rb.AddForce (force);
		}
	}
}

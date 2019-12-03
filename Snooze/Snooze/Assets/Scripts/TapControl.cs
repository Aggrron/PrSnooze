using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapControl : MonoBehaviour {

	private Vector2 st_pos;
	private Vector2 next_pos;

	public Rigidbody2D rb;

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
			rb.AddForce (st_pos - next_pos);
		}
	}
}

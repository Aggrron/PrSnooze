using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SnoozeControl : MonoBehaviour {
	
	public Rigidbody2D rb;

	private Vector2 st_pos;
	private Vector2 next_pos;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
		
	void OnMouseDown(){
		st_pos = Input.mousePosition;
	}
	void OnMouseUp(){
		next_pos = Input.mousePosition;
		rb.AddForce (st_pos - next_pos);
		//Debug.Log(next_pos);
	}
}

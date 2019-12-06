using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SnoozeControl : MonoBehaviour {
	
	public Rigidbody2D rb;

	public int Score = 0;

	public void ChangeScore(int diff){
		Score += diff;
	}
	public void PrintScore(){
		Debug.Log (Score);
	}


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
		
	void OnMouseUp(){
		//rb.constraints = RigidbodyConstraints2D.None;

		//Debug.Log(next_pos);
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Wall") {
			rb.constraints = RigidbodyConstraints2D.FreezePositionY|RigidbodyConstraints2D.FreezePositionX|RigidbodyConstraints2D.FreezeRotation;


		}
	}

}

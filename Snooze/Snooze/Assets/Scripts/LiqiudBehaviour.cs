using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiqiudBehaviour : MonoBehaviour {

	public float speed = 1f;
	public float bonusY = 10f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
	}

	public void LiquidBoost(){
		//speed = speed + 1f;
		//transform.position = new Vector3 (transform.position.x, transform.position.y + bonusY, transform.position.z);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Kozyavka") {
			Debug.Log("Got!!");
			//transform.position = new Vector3 (transform.position.x, transform.position.y + bonusY * Time.deltaTime, transform.position.z);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KozyavkaDestroyer : MonoBehaviour {
	
	SnoozeControl snoozeScr;

	void Start () {
	 	GameObject soplya = GameObject.Find ("Soplya");
		SnoozeControl snoozeScript = soplya.GetComponent<SnoozeControl> ();
		setScript (snoozeScript);
	}

	void setScript(SnoozeControl script){
		snoozeScr = script;
	}

	SnoozeControl getScript(){
		return snoozeScr;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Floor") {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "HitBox") {
			SnoozeControl script = getScript ();
			script.ChangeScore (1);
			script.PrintScore ();
			Destroy (gameObject);
		}
	}
}

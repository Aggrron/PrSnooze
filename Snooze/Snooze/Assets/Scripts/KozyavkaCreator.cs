using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KozyavkaCreator : MonoBehaviour {

	public GameObject koz;
	private float nextSpawnTime = 0.0f;
	public float period = 0.5f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawnTime) {
			nextSpawnTime += period;
			//Debug.Log(transform.localPosition);
			Vector3 new_position = transform.localPosition;
			new_position [0] = Random.Range (-2f, 2f);
			Instantiate(koz, new_position,Quaternion.identity);

		}
	}
}

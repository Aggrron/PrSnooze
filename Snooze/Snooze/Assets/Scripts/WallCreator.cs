using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreator : MonoBehaviour {

	public GameObject wall_l;
	public GameObject wall_r;

	public GameObject pos_detector;
	public GameObject wall_end;

	private int counter;
	private bool wall_flag;

	void Start () {
		counter = 1;
		wall_flag = false;
		
	}

	void CreateWall(){
		Vector3 new_wall_pos_l = wall_end.transform.position;
		Vector3 new_wall_pos_r = wall_end.transform.position;
		new_wall_pos_l [1] = (7 * counter) + (7 / 2);
		new_wall_pos_r [0] = 2.78f;
		new_wall_pos_r [1] = (7 * counter) + (7 / 2);
		Instantiate(wall_l, new_wall_pos_l, Quaternion.identity);
		Instantiate (wall_r, new_wall_pos_r, Quaternion.identity);
		wall_flag = false;
		counter += 1;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 cam_pos = pos_detector.transform.position;
		if (cam_pos [1] >= 7*counter) {
			wall_flag = true;
		}
		if (wall_flag) {
			CreateWall ();
		}


	}
}

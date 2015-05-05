using UnityEngine;
using System.Collections;

public class doorOpening : MonoBehaviour {

	public bool open;
	public float t;
	public Vector3 pos;
	public Transform wall;

	// Use this for initialization
	void Start () {
	
		open = false;
		pos = transform.position;
		t = 0;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (open == true && t > 0) {
						t = t - 0.03f;
		


				} else if (open== false && t<1){

			t=t + 0.03f;

				}

		transform.position = Vector3.Lerp(wall.position,pos,t);


		/*
		else{
			transform.position = Vector3.Lerp(pos,wall.position,0.1f);

		}
*/


	
	}
}

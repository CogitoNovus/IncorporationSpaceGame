using UnityEngine;
using System.Collections;

public class sluiceControlThree : MonoBehaviour {

	public sluiceControlTwo two;
	public bool opening;
	public float t;
	private int mult;
	private float theTime;
	private bool anuller;

	// Use this for initialization
	void Start () {
	
		mult = 1;

	}
	
	// Update is called once per frame
	void Update () {
	
		if(two.t<0.2f){
			theTime = Time.time;
			anuller = true;
		

		}

		if(Time.time-3 > theTime && anuller == true){
			opening = true;
			anuller = false;
		}

	

		if (opening == true && t <= 115 && t >= 0) {
						t += 0.1f*mult;
				} else if (t <= 0) {
			t=0;
			mult = 1;
			opening = false;
		} else if (t>=115){
			t=115;
			mult = -1;
			opening =false;
		}

		transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + t,transform.rotation.z );
	}
}

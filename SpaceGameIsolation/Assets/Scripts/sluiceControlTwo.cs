using UnityEngine;
using System.Collections;

public class sluiceControlTwo : MonoBehaviour {

	public bool pulled;
	public float t;

	// Use this for initialization
	void Start () {
	
		t = 1;
		pulled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (pulled == true && t > 0) {
			t = t - 0.03f;
			if(t<0){
				pulled=false;
			}
			
			
			
		} else if (pulled== false && t<1){
			
			t=t + 0.01f;
			
		}

		transform.rotation = Quaternion.Euler (transform.rotation.x, transform.rotation.y, transform.rotation.z-(t*60)+60);



	}
}

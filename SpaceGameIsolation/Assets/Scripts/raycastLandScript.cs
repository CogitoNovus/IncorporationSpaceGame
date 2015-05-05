using UnityEngine;
using System.Collections;

public class raycastLandScript : MonoBehaviour {

	public GameObject Target;
	public GameObject Body;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Ray ray = new Ray (transform.position,transform.forward);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit) && Input.GetButtonDown ("Fire1")) {
						Target = hit.collider.gameObject;
				} else {
			Target = null;
				}

		if(Target != null){
			transform.LookAt(Target.transform.position);
		}


	}
}

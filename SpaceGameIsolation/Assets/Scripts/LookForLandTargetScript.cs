using UnityEngine;
using System.Collections;

public class LookForLandTargetScript : MonoBehaviour {

	public GameObject Target;

	public int rayRange = 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Ray ray = new Ray (transform.position,transform.forward);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, rayRange) && Input.GetKeyDown (KeyCode.Tab)) {
			Target = hit.collider.gameObject;
		}else if(!hit.collider && Input.GetKeyDown(KeyCode.Tab)){
			Target = null;
		}

	}
}

using UnityEngine;
using System.Collections;

public class moveForwardScript : MonoBehaviour {

	private Rigidbody rb;
	public GameObject head;

	// Use this for initialization
	void Start () {
	
		rb = gameObject.GetComponent<Rigidbody>();
		head = gameObject.transform.GetChild(1).gameObject;

	}
	
	// Update is called once per frame
	void Update () {
	
		rb.MoveRotation(head.transform.rotation);

		if(Input.GetButton("Fire1")){
			rb.AddForce(gameObject.transform.forward);
		}

	}
}

using UnityEngine;
using System.Collections;

public class slowRandomMovement : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
		Rigidbody rb = GetComponent<Rigidbody>();
		rb.AddForce (new Vector3(Random.Range(0,10),Random.Range(0,10),Random.Range(0,10))*100);
		             rb.AddTorque (new Vector3(Random.Range(0,10),Random.Range(0,10),Random.Range(0,10))*10);


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

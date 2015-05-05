using UnityEngine;
using System.Collections;

public class blindControl : MonoBehaviour {

	public blindOpener blind;
	public bool canOpen;

	// Use this for initialization
	void Start () {

		canOpen = false;

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1") && canOpen==true){
		blind.open = !blind.open;
		}

	}

	void OnTriggerStay(Collider coll ){
		if (coll.gameObject.tag == "Player") {

			canOpen=true;
		} 

	}

	void OnTriggerExit(Collider coll){
		if (coll.gameObject.tag == "Player") {
			canOpen=false;
		} 
		

	}

}

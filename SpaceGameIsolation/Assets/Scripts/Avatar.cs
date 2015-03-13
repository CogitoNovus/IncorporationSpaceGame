using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour {


	public static bool drill = false;

	// Update is called once per frame
	void Update () {

		//Debug.Log(drill);
		//Debug.Log(rigidbody.velocity);
	
		if(Input.GetKeyDown(KeyCode.A)){
		
		if (GetComponent<Rigidbody>().velocity.z < 1.5f){

		OxygenMeter.oxyLvl -= 0.001f;
		GetComponent<Rigidbody>().AddTorque(gameObject.transform.up * -0.5f); 
		GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 1); 

			}
		}

		if(Input.GetKeyDown(KeyCode.D)){

			if (GetComponent<Rigidbody>().velocity.x < 1.5f){
			
			OxygenMeter.oxyLvl -= 0.001f;
			GetComponent<Rigidbody>().AddTorque(gameObject.transform.up * 0.5f); 
			GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 1);
		}
		}

		if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)){


				OxygenMeter.oxyLvl -= 0.001f;
				GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 3); 


		}

		if(Input.GetKey(KeyCode.W)){

				OxygenMeter.oxyLvl -= 0.001f;
				GetComponent<Rigidbody>().AddForce(gameObject.transform.up * 2); 
			
		}

		if(Input.GetKey(KeyCode.S)){
		
				OxygenMeter.oxyLvl -= 0.001f;
				GetComponent<Rigidbody>().AddForce(gameObject.transform.up * -2);
			
		}

		if(Input.GetKey(KeyCode.Space)){
			
			drill = true;
			
		}
		else {
			drill = false;
		}

	}
}

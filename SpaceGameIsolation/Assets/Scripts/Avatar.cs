using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour {

	public bool ClassicControls = false;

	public static bool drill = false;

	public Rigidbody rb;

	public int stabSpeed = 1;

	void Start () {

		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {

		//Debug.Log(drill);
		//Debug.Log(rigidbody.velocity);
	
		if(Input.GetKey(KeyCode.A)){

		OxygenMeter.oxyLvl -= 0.001f;
		rb.AddTorque(gameObject.transform.up * -1 * Time.deltaTime); 
		rb.AddForce(gameObject.transform.forward * 1); 

		}

		if(Input.GetKey(KeyCode.D)){
			
		OxygenMeter.oxyLvl -= 0.001f;
		rb.AddTorque(gameObject.transform.up * 1 * Time.deltaTime); 
		rb.AddForce(gameObject.transform.forward * 1);
		
		}

		if (ClassicControls == false){

		if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)){


				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.forward * 3); 


		}

		if(Input.GetKey(KeyCode.W)){

				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.up * 2); 
			
		}

		if(Input.GetKey(KeyCode.S)){
		
				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.up * -2);
			
			}}
		if (ClassicControls == true){

			if(Input.GetKey(KeyCode.W)){
				
				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.forward * 2); 
				
			}

			if(Input.GetKey(KeyCode.S)){
				
				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.forward * -2); 
				
			}

			if(Input.GetKey(KeyCode.Q)){
				
				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.up * -2); 
				
			}

			if(Input.GetKey(KeyCode.E)){
				
				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.up * 2); 
				
			}

		}

		if(Input.GetKeyDown(KeyCode.LeftShift)){

			Stabilize();
		}

		if(Input.GetKey(KeyCode.Space)){
			
			drill = true;
			
		}
		else {
			drill = false;
		}
	}

	void Stabilize(){

			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;

	}

	/*void OnTriggerStay(Collider other)
	{
		if(other.gameObject.tag == "Asteroid"){
			
			Debug.Log("HE'S IN!!");
			Asteroid.visible = true;
		}
		
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Asteroid"){
			
			Debug.Log("HE'S NOT IN!!!?!");
			Asteroid.visible = false;
		}
		
	}*/
}


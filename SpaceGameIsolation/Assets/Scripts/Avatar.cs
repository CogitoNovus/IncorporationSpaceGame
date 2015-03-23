using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour {

	public bool ClassicControls = false;

	public static bool drill = false;

	public Rigidbody rb;

	public int speed = 1;

	public int stabSpeed = 1;

	public GameObject breadLight;

	void Start () {

		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {

		//Debug.Log(drill);
		//Debug.Log(rigidbody.velocity);
	
		if(Input.GetKey(KeyCode.A)){

		OxygenMeter.oxyLvl -= 0.001f;
		rb.AddTorque(gameObject.transform.up * -speed * Time.deltaTime); 
			rb.AddForce(gameObject.transform.forward * speed); 

		}

		if(Input.GetKey(KeyCode.D)){
			
		OxygenMeter.oxyLvl -= 0.001f;
			rb.AddTorque(gameObject.transform.up * speed * Time.deltaTime); 
			rb.AddForce(gameObject.transform.forward * speed);
		
		}

		if (ClassicControls == false){

		if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)){


				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.forward * speed); 


		}

		if(Input.GetKey(KeyCode.W)){

				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.up * speed * 2); 
			
		}

		if(Input.GetKey(KeyCode.S)){
		
				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.up * -speed);
			
			}}
		if (ClassicControls == true){

			if(Input.GetKey(KeyCode.W)){
				
				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.forward * speed * 2); 
				
			}

			if(Input.GetKey(KeyCode.S)){
				
				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.forward * -speed); 
				
			}

			if(Input.GetKey(KeyCode.Q)){
				
				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.up * -speed * 2); 
				
			}

			if(Input.GetKey(KeyCode.E)){
				
				OxygenMeter.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.up * speed * 2); 
				
			}

		}

		if(Input.GetKeyDown(KeyCode.LeftShift)){

			Stabilize();
		}

		if (Input.GetKeyDown(KeyCode.LeftControl)){

			Instantiate (breadLight, new Vector3 (transform.position.x, transform.position.y, transform.position.z), transform.rotation);
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

	void OnTriggerEnter(Collider other)
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
		
	}
}


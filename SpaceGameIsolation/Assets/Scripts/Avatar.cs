using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour {

	public bool ClassicControls = false;

	public bool NewControls = false;

	public static bool drill = false;

	public Rigidbody rb;

	public static float personalMineral;

	public int speed = 2;

	public int stabSpeed = 1;

	public GameObject spawnPoint;

	public GameObject breadLight;

	public GameObject flashLight;

	public GameObject guideLine;

	public Vector3 vel;

	void Start () {

		rb = GetComponent<Rigidbody>();
		vel = rb.velocity;
	}

	// Update is called once per frame
	void Update () {

		Debug.Log(personalMineral);
		//Debug.Log (drill);
			
		if (drill == true && PlayerResource.energyLvl > 0){

			PlayerResource.energyLvl -= 2;
		}

		if (drill == false && PlayerResource.energyLvl <= 100){

			PlayerResource.energyLvl += 1;
		}

		if (ClassicControls == false && NewControls == false){

		if(Input.GetKey(KeyCode.A)){

		PlayerResource.oxyLvl -= 0.001f;
		rb.AddTorque(gameObject.transform.up * -speed * Time.deltaTime); 
			rb.AddForce(gameObject.transform.forward * speed); 

		}

		if(Input.GetKey(KeyCode.D)){
			
		PlayerResource.oxyLvl -= 0.001f;
			rb.AddTorque(gameObject.transform.up * speed * Time.deltaTime); 
			rb.AddForce(gameObject.transform.forward * speed);
		
		}



		if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)){


				PlayerResource.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.forward * speed); 


		}

		if(Input.GetKey(KeyCode.W)){

				PlayerResource.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.up * speed * 2); 
			
		}

		if(Input.GetKey(KeyCode.S)){
		
				PlayerResource.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.up * -speed);
			
			}}
		if (ClassicControls == true){

			if(Input.GetKey(KeyCode.W)){
				
				PlayerResource.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.forward * speed * 2); 	
				
			}

			if(Input.GetKey(KeyCode.S)){
				
				PlayerResource.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.forward * -speed); 
				
			}

			if(Input.GetKey(KeyCode.Q)){
				
				PlayerResource.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.up * -speed * 2); 
				
			}

			if(Input.GetKey(KeyCode.E)){
				
				PlayerResource.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.up * speed * 2); 
				
			}

		}

		if(NewControls == true && ClassicControls == false){

			/*
			bool leftShift = false;

			if (Input.GetKey(KeyCode.LeftShift)){

				leftShift = true;
			}

			else { leftShift = false; }

			Debug.Log(leftShift);

			*/

			if (Input.GetKey(KeyCode.Space)){

				PlayerResource.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.forward * speed * 4);

			}

			/*if (Input.GetKey(KeyCode.S) && leftShift == false){

				PlayerResource.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.forward * -speed * 4);
			}

			if (Input.GetKey(KeyCode.A) && leftShift == false){

				PlayerResource.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.right * -speed * 4);
				
			}

			if (Input.GetKey(KeyCode.D) && leftShift == false){

				PlayerResource.oxyLvl -= 0.001f;
				rb.AddForce(gameObject.transform.right * speed * 4);
				
			}*/

			if (Input.GetKey(KeyCode.W)){
				
				PlayerResource.oxyLvl -= 0.001f;
				rb.AddTorque(gameObject.transform.right * speed * Time.deltaTime * 8); 
			}

			if (Input.GetKey(KeyCode.S)){

				PlayerResource.oxyLvl -= 0.001f;
				rb.AddTorque(gameObject.transform.right * -speed * Time.deltaTime * 8); 
			}

			if (Input.GetKey(KeyCode.A)){

				PlayerResource.oxyLvl -= 0.001f;
				rb.AddTorque(gameObject.transform.up * -speed * Time.deltaTime * 8); 
				
			}

			if (Input.GetKey(KeyCode.D)){

				PlayerResource.oxyLvl -= 0.001f;
				rb.AddTorque(gameObject.transform.up * speed * Time.deltaTime * 8); 
			}

		}



		if(Input.GetKey(KeyCode.LeftShift)){

			Stabilize();
		}

		if (Input.GetKeyDown(KeyCode.LeftControl) && itemCount.items != 0){

			itemCount.items -= 1;

			Instantiate (breadLight, new Vector3 (spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z), spawnPoint.transform.rotation);
		}

		if (Input.GetKeyDown (KeyCode.F)){

			if (flashLight.activeInHierarchy == false){

			flashLight.SetActive(true);

			}

			else if (flashLight.activeInHierarchy == true){
				
				flashLight.SetActive(false);
				
			}
		}


		if(Input.GetMouseButton(0) && PlayerResource.energyLvl != 0){
		//if (Input.GetKey(KeyCode.Return)){	
			drill = true;

		}
		else {
			drill = false;
		}

		/*if (PlayerResource.energyLvl == 0){

			drill = false;
		}*/
	}
	
	void Stabilize(){

		float step = 1f * Time.deltaTime;

		rb.velocity = Vector3.MoveTowards(rb.velocity, Vector3.zero, step);
		rb.angularVelocity = Vector3.MoveTowards(rb.angularVelocity, Vector3.zero, step);

		/*rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;*/
	}
	

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Oxy" && PlayerResource.oxyLvl < 100){
			
			PlayerResource.oxyLvl += 10;
		}

		if(other.gameObject.tag == "Asteroid"){
			
			//Debug.Log("HE'S IN!!!");


			//Vector3 v = new Vector3(other.transform.position.x - gameObject.transform.position.x, other.transform.position.y - gameObject.transform.position.y, other.transform.position.z - gameObject.transform.position.z);

		/*	Vector3 relativePos = other.transform.position - gameObject.transform.position;

			guideLine.transform.rotation = Quaternion.LookRotation(relativePos);

			rb.AddForce(relativePos);

			Stabilize();*/

			//v.Normalize();
			
			//rb.AddForce(v);
		}
	}
}


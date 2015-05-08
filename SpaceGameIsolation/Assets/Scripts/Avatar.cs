using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour {
	
	public static bool drill = false;

	public static bool scan = false;

	public static bool canMove = true;

	public Rigidbody rb;

	public static int personalMineral;

	public int speed = 2;

	public int stabSpeed = 1;

	public GameObject spawnPoint;

	public GameObject breadLight;

	public GameObject flashLight;

	public GameObject guideLine;

	public GameObject Diegetic;

	public Vector3 vel;

	public GameObject g;

	void Start () {

		g = GameObject.Find("Sound Manager");
		rb = GetComponent<Rigidbody>();
		vel = rb.velocity;
	}

	// Update is called once per frame
	void FixedUpdate () {


		if (drill == true && PlayerResource.energyLvl > 1){

			PlayerResource.energyLvl -= 1;
		}

		if (drill == false && PlayerResource.energyLvl <= 200){

			PlayerResource.energyLvl += 1;
		}

		if (canMove == true){

		if (Input.GetKey(KeyCode.Space)){

			//PlayerResource.oxyLvl -= 1;
			rb.AddForce(gameObject.transform.forward * speed * 4);
		


			if(!g.GetComponent<SoundManager>().sources[1].isPlaying){
			g.GetComponent<SoundManager>().Player(1);
			}

			}
		else {g.GetComponent<SoundManager>().sources[1].Stop();}
		
		if (Input.GetKey(KeyCode.W)){
				
				//PlayerResource.oxyLvl -= 1;
				rb.AddTorque(gameObject.transform.right * speed * Time.deltaTime * 8); 
			}

			if (Input.GetKey(KeyCode.S)){

				//PlayerResource.oxyLvl -= 1;
				rb.AddTorque(gameObject.transform.right * -speed * Time.deltaTime * 8); 
			}

			if (Input.GetKey(KeyCode.A)){

				//PlayerResource.oxyLvl -= 1;
				rb.AddTorque(gameObject.transform.up * -speed * Time.deltaTime * 8); 
				
			}

			if (Input.GetKey(KeyCode.D)){

				//PlayerResource.oxyLvl -= 1;
				rb.AddTorque(gameObject.transform.up * speed * Time.deltaTime * 8); 
		}

		}

		if (Input.GetKeyDown(KeyCode.E)){
			
			if (Diegetic.activeInHierarchy == false){
				
				Diegetic.SetActive(true);
				
			}
			
			else if (Diegetic.activeInHierarchy == true){
				
				Diegetic.SetActive(false);
				
			}
		}

		if (Input.GetKeyDown(KeyCode.Q) && UIControl.control){
			
			
			UIControl.control = false;
			
		}

		if(Input.GetKey(KeyCode.LeftShift)){

			Stabilize();
		}

		if (Input.GetKeyDown(KeyCode.LeftControl) && itemCount.items != 0){

			itemCount.items -= 1;

			Instantiate (breadLight, new Vector3 (spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z), spawnPoint.transform.rotation);
		}

		if (Input.GetMouseButton(1)){

			scan = true;
		}
		if (Input.GetMouseButtonUp(1)){

			scan = false;
		}

		if (Input.GetKeyDown (KeyCode.F)){

			if (flashLight.activeInHierarchy == false){

			flashLight.SetActive(true);

			g.GetComponent<SoundManager>().Player(3);

			}

			else if (flashLight.activeInHierarchy == true){
				
			flashLight.SetActive(false);

			g.GetComponent<SoundManager>().Player(3);
				
			}
		}

		if (PlayerResource.energyLvl == 0){

			drill = false;
		}
	}

	void OnTriggerStay (Collider other){
	
	if (other.gameObject.tag == "Mineral"){
	
	if(Input.GetMouseButton(0) && PlayerResource.energyLvl > 1){
		
		drill = true;
	//Sound
		GameObject g = GameObject.Find("Sound Manager");
		
		if (!g.GetComponent<SoundManager>().sources[2].isPlaying && PlayerResource.energyLvl > 2){
		g.GetComponent<SoundManager>().Player(2);
		}
	}
	else {
		drill = false;
		g.GetComponent<SoundManager>().sources[2].Stop();
	}
	}
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

	}
}


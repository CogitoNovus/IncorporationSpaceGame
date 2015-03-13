using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	public bool canHarvest = false;

	static public bool visible = false;

	public float mineralAmount = 100;

	// Update is called once per frame
	void Update () {

		if (gameObject.tag == "Mineral"){

			//canHarvest = true;

			gameObject.GetComponent<Renderer>().material.color = Color.blue;


		}

		if (visible == true){

			gameObject.GetComponent<MeshRenderer>().enabled = true;
		}

		if (visible == false){

			gameObject.GetComponent<MeshRenderer>().enabled = false;
		}

		if (Avatar.drill == true && canHarvest == true){

			mineralAmount -= 0.1f;
			
			Debug.Log(mineralAmount);
		}
		
		if (mineralAmount <= 0){
			
			canHarvest = false;
		}
	
	}

	void OnCollisionEnter (Collision other) {

		if (this.gameObject.tag == "Mineral" && other.gameObject.tag == "Player"){

			Debug.Log(canHarvest);
			canHarvest = true;
		}
	}

	void OnCollisionExit (Collision other) {
		
		if (this.gameObject.tag == "Mineral" && other.gameObject.tag == "Player"){
			
			Debug.Log(canHarvest);
			canHarvest = false;
		}
	}
}

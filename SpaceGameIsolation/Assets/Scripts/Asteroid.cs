using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	public bool canHarvest = false;

	public static bool visible = true;

	public int mineralAmount = 1000;
	
	public SphereCollider mineralCollider;

	void Start () {

		mineralCollider = gameObject.GetComponent<SphereCollider>();
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (gameObject.tag == "Mineral"){

			//canHarvest = true;

			mineralCollider.enabled = true;

			if (Avatar.scan == true){
			gameObject.GetComponent<Renderer>().material.color = Color.blue;
			}
			if (Avatar.scan == false){
				gameObject.GetComponent<Renderer>().material.color = Color.gray;
			
			}
		}

		if (mineralAmount <= 0){

			gameObject.tag = "Asteroid";
		}

		if (Avatar.drill == true && canHarvest == true && PlayerResource.energyLvl != 1){

			mineralAmount -= 1;

			Avatar.personalMineral += 1;

		}
		
		if (mineralAmount == 0 || PlayerResource.energyLvl == 1){
			
			canHarvest = false;
		}
	
	}

	void OnTriggerStay (Collider other) {

		if (other.gameObject.tag == "Player" && mineralAmount != 0){

			//Debug.Log(canHarvest);
			canHarvest = true;
		}

		//else {canHarvest = false;}
	}
	void OnTriggerExit (Collider other) {

		if (other.gameObject.tag == "Player"){

			canHarvest = false;
	}
	}

}



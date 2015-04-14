using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	public bool canHarvest = false;

	public static bool visible = true;

	public float mineralAmount = 100;

	// Update is called once per frame
	void Update () {

		if (gameObject.tag == "Mineral"){

			//canHarvest = true;

			gameObject.GetComponent<Renderer>().material.color = Color.blue;


		}

	/*	if (visible == true){

			this.gameObject.GetComponent<MeshRenderer>().enabled = true;
		}

		if (visible == false){

			this.gameObject.GetComponent<MeshRenderer>().enabled = false;
		}*/

		if (Avatar.drill == true && canHarvest == true){

			mineralAmount -= 1 * Time.deltaTime;

			Avatar.personalMineral += 1 * Time.deltaTime;

		}
		
		if (mineralAmount <= 0){
			
			canHarvest = false;
		}
	
	}

	void OnTriggerStay (Collider other) {

		if (this.gameObject.tag == "Mineral" && other.gameObject.tag == "Player" && mineralAmount < 10){

			//Debug.Log(canHarvest);
			canHarvest = true;
		}

		else {canHarvest = false;}
	}

	/*void OnTriggerExit (Collider other) {
		
		if (this.gameObject.tag == "Mineral" && other.gameObject.tag == "Player"){
			
			Debug.Log(canHarvest);
			canHarvest = false;
		}
	}*/

	/*void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player"){
			
			Debug.Log("HE'S IN!!");
			visible = true;
		}

	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player"){
			
			Debug.Log("HE'S NOT IN!!!?!");
			visible = false;
		}

}*/
}



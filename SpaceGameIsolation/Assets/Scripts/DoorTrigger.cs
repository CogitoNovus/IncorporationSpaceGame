using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

	public GameObject door;
	public GameObject dooret;
	public GameObject doorTwo;
	public GameObject doorThree;

	void Start(){

		door = transform.FindChild ("Wall 1/door").gameObject;
		dooret = transform.FindChild ("Wall 2/door 1").gameObject;
		doorTwo = transform.FindChild ("Wall 3/door 2").gameObject;
		doorThree = transform.FindChild ("Wall 4/door 3").gameObject;
	}

	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.tag=="Player"){

		door.GetComponent<doorOpening>().open=true;
		

			dooret.GetComponent<doorOpening>().open=true;


			doorTwo.GetComponent<doorOpening>().open=true;


			doorThree.GetComponent<doorOpening>().open=true;
		}
	}

	void OnTriggerExit(Collider coll){
		if(coll.gameObject.tag =="Player"){
		
		door.GetComponent<doorOpening>().open=false;


			dooret.GetComponent<doorOpening>().open=false;

			doorTwo.GetComponent<doorOpening>().open=false;

			doorThree.GetComponent<doorOpening>().open=false;
		}
	}

}

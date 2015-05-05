using UnityEngine;
using System.Collections;

public class LandingScript : MonoBehaviour {

	public Rigidbody rb;
	public GameObject Target;
	public Rigidbody trb;
	public Vector3 trbV;
	public Vector3 trbAV;
	public GameObject head;
	private Quaternion objectRot;
	//public GameObject rayCasterStick;


	// Use this for initialization
	void Start () {
	
		rb = gameObject.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
	
		Target = head.GetComponent<LookForLandTargetScript>().Target;

		if (Target != null) {
						Vector3 relTarget = (Target.transform.position - gameObject.transform.position).normalized;
						rb.AddForce (relTarget * 200);


						//HER SKRIVES CONTROL SCRIPTED IND:
						//gameObject.GetComponent<moveForwardScript> ().enabled =false;
			Avatar.canMove = false;

			//gameObject.transform.rotation = Quaternion.Lerp(objectRot,Quaternion.Euler(relTarget),3);

		} else { Avatar.canMove = true;
						//HER SKRIVES CONTROL SCRPTED IND IGEN:
						//gameObject.GetComponent<moveForwardScript> ().enabled = true;
		//	objectRot = gameObject.transform.rotation;
				}


	}

	void OnTriggerStay(Collider col){

		if(col.gameObject == Target){
			WalkOnAsteroid();

			if(Target.GetComponent<Rigidbody>() != null){
				trb = Target.GetComponent<Rigidbody>();
				trbV = trb.velocity;
				trbAV = trb.angularVelocity;

				//trb.AddForce((gameObject.transform.position - Target.transform.position).normalized);
			}

		}

	}

	void WalkOnAsteroid(){

		//rb.isKinematic = true;

		//gameObject.transform.IsChildOf (Target.transform);

		Target.GetComponent<Rigidbody>().velocity = trbV;
		Target.GetComponent<Rigidbody> ().angularVelocity = trbAV;

	}
	


}

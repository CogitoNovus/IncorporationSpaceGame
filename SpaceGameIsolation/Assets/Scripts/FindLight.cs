using UnityEngine;
using System.Collections;

public class FindLight : MonoBehaviour {

	//values that will be set in the Inspector
	public Transform Target;
	public Transform ObjectToTurn;
	public GameObject Pointer;
	public GameObject TrackTextObj;
	public GameObject TargetObj;
	public GameObject Head;
	public TextMesh TrackText;
	public bool Toggle = true;
	public static bool PickedUp = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Q) && Toggle == true){

			Pointer.SetActive(false);
			TrackTextObj.SetActive(false);
			Toggle = false;
			GetComponent<SphereCollider>().enabled = false;
		}

		else if (Input.GetKeyDown(KeyCode.Q) && Toggle == false){
			
			Pointer.SetActive(true);
			TrackTextObj.SetActive(true);
			Toggle = true;
			GetComponent<SphereCollider>().enabled = true;
		}

		if (PickedUp == true){
			
			Target = null;
			TargetObj = null;
			ObjectToTurn.transform.rotation = Head.transform.rotation;
			TrackText.text = "No Target";
		}

		/*RaycastHit hit;
		Ray ray =  new Ray(transform.position, 20, Vector3.zero, out hit, 0);
		if(hit.collider.gameObject.tag == "Breadcrumb"){

			//hit.
		}*/
	}

	void LateUpdate () {

		if (PickedUp == true){

			PickedUp = false;
		}
	}

	void OnTriggerStay (Collider other){

		if (other.gameObject.tag == "Breadcrumb"){

			TargetObj = other.gameObject;

			Target = TargetObj.transform;

			TrackText.text = "Tracking position";

			Track();

		}

	}

	void OnTriggerExit (Collider other){

		if (other.gameObject.tag == "Breadcrumb"){

			Target = null;
			TargetObj = null;
			ObjectToTurn.transform.rotation = Head.transform.rotation;
			TrackText.text = "No Target";
		}
	}

	void Track () {

		ObjectToTurn.transform.LookAt(Target);
	}
	
}

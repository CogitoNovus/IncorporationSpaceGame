using UnityEngine;
using System.Collections;

public class BodyReferenceLookAt : MonoBehaviour {

	public Transform lookAtPoint;
	public Transform avatar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.LookAt (lookAtPoint.transform.position);
		print (transform.rotation);
		//transform.rotation = Quaternion.Euler(new Vector3 (transform.rotation.x, transform.rotation.y, avatar.rotation.z));

	}
}

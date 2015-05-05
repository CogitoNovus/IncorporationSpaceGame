using UnityEngine;
using System.Collections;

public class armsLookatPointLerper : MonoBehaviour {

	public Transform Target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = Vector3.Lerp (transform.position, Target.position, 0.2f);

	}
}

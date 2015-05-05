using UnityEngine;
using System.Collections;

public class armDirection : MonoBehaviour {

	public Quaternion rot;
	public Transform avatar;
	public Transform refPoint;

	// Use this for initialization
	void Start () {
	
		rot = transform.rotation;

	}
	
	// Update is called once per frame
	void Update () {
	
		//transform.rotation = rot * avatar * refPoint.transform.rotation;

	}
}

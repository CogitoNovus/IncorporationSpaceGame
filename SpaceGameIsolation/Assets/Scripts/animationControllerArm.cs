using UnityEngine;
using System.Collections;

public class animationControllerArm : MonoBehaviour {

	public bool breadcrumbEquip;

	// Use this for initialization
	void Start () {
		breadcrumbEquip = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButtonDown ("Fire1"))
						breadcrumbEquip = true;
	}
}

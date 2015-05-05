using UnityEngine;
using System.Collections;

public class DiegeticEnergyBar : MonoBehaviour {

	public float energy;

	public GameObject parentObject;

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		energy = PlayerResource.energyLvl;

		Vector3 energyGui = new Vector3 (energy/2*0.01f, transform.localScale.y, transform.localScale.z);

			parentObject.transform.localScale = energyGui;

	}
}

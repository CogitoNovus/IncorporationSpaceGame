using UnityEngine;
using System.Collections;

public class PlayerResource : MonoBehaviour {

	static public float oxyLvl;
	static public float energyLvl;

	// Use this for initialization
	void Start () {
		
		oxyLvl = 100;
		energyLvl = 100;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (oxyLvl >= 0){
			oxyLvl -= 0.01f;
		}
		
	}
}

using UnityEngine;
using System.Collections;

public class OxygenMeter : MonoBehaviour {

	static public float oxyLvl;

	// Use this for initialization
	void Start () {
	
		oxyLvl = 100;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (oxyLvl > 0){
		oxyLvl -= 0.001f;
		}
		//Debug.Log(oxyLvl);

		/*if (oxyLvl == 0){

			Debug.Log("DEATH!");
		}

		if (oxyLvl > 0){

			Debug.Log("ALIVE!");*/


	}}
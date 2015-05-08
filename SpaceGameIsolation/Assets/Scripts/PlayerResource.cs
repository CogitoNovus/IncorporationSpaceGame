using UnityEngine;
using System.Collections;

public class PlayerResource : MonoBehaviour {

	static public int oxyLvl;
	static public int energyLvl;

	static public int maxOxy = 20000;
	static public int maxEnergy = 200;

	// Use this for initialization
	void Start () {

		oxyLvl = maxOxy;
		energyLvl = maxEnergy;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (oxyLvl != 0){
			oxyLvl -= 1;
		}

		if (oxyLvl < 5000){

			alarmTrigger.lowOxy = true;
		}

		if (oxyLvl > 5000){

			alarmTrigger.lowOxy = false;
		}
	}

}

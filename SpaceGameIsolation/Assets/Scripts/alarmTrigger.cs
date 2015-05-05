using UnityEngine;
using System.Collections;

public class alarmTrigger : MonoBehaviour {

	public static bool lowOxy = false;

	public AudioSource alarmSound;

	// Update is called once per frame
	void Update () {

		if (lowOxy == true){

			alarmSound.enabled = true;
		}

		if (lowOxy == false){
			
			alarmSound.enabled = false;
		}
	}
}

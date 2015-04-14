﻿using UnityEngine;
using System.Collections;

public class LevelTrigger : MonoBehaviour {

	void OnTriggerEnter (Collider other){

		if (other.gameObject.tag == "Player"){

			Application.LoadLevel("Asteroid Level");
		}
	}
}

using UnityEngine;
using System.Collections;

public class AsteroidPiece : MonoBehaviour {

	public static bool accel = false;

	// Update is called once per frame
	void Update () {
	
		if (accel == true){

			Vector3 explosion = new Vector3	(Random.Range(0, 360),Random.Range(0, 360),Random.Range(0, 360));

			GetComponent<Rigidbody>().AddForce(explosion);

		}
	}
}

using UnityEngine;
using System.Collections;

public class Surface : MonoBehaviour {

	public void OnCollisionEnter (Collision other){

		if (other.gameObject.tag == "Player"){}

	}
}

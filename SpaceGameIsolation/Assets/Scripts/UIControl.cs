using UnityEngine;
using System.Collections;

public class UIControl : MonoBehaviour {

	public static bool control = true;

	public GameObject UIGameObject;
	
	// Update is called once per frame
	void Update () {
	
		if (control == true){

			UIGameObject.SetActive(true);

		}

		if (control == false){

			UIGameObject.SetActive(false);

		}
	}
}

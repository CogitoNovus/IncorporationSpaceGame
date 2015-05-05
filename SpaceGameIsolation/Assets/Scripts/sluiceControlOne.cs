using UnityEngine;
using System.Collections;

public class sluiceControlOne : MonoBehaviour {

	public sluiceControlTwo leverControl;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerStay(Collider coll){
		if(coll.gameObject.tag =="Player"){
			if(Input.GetButtonDown("Fire1")){
				leverControl.pulled = !leverControl.pulled;
			}

		}
	}
}

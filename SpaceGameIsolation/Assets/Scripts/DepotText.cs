using UnityEngine;
using System.Collections;

public class DepotText : MonoBehaviour {


	// Update is called once per frame
	void Update () {
	
		GetComponent<TextMesh>().text = deposit.depositedMineral.ToString();

		if (deposit.depositedMineral == 10000){

			GetComponent<TextMesh>().color = Color.green;
		}
	}
}

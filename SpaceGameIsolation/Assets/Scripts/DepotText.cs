using UnityEngine;
using System.Collections;

public class DepotText : MonoBehaviour {


	// Update is called once per frame
	void Update () {
	
		GetComponent<TextMesh>().text = deposit.depositedMineral.ToString();

	}
}

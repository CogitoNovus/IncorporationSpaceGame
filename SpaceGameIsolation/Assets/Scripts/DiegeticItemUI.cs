using UnityEngine;
using System.Collections;

public class DiegeticItemUI : MonoBehaviour {

	// Update is called once per frame
	void Update () {
	
		GetComponent<TextMesh>().text = "Lights: " + itemCount.items.ToString();
	}
}

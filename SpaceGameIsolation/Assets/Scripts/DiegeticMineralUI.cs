using UnityEngine;
using System.Collections;

public class DiegeticMineralUI : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		GetComponent<TextMesh>().text = "Minerals: " + Avatar.personalMineral.ToString();
	
	}
}

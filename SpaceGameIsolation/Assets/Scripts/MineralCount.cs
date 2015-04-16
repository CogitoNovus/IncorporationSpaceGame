using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MineralCount : MonoBehaviour {

	public static float minerals;

	Text text;
	
	void Start () {
		
		text = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {

		minerals = Avatar.personalMineral;

		text.text = "Mineral: " + minerals;
		
		
		
	}
}

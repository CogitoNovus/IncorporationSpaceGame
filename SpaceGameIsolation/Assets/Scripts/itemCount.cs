using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class itemCount : MonoBehaviour {

	public static int items = 10;

	Text text;

	void Start () {

		text = GetComponent<Text>();

	}

	// Update is called once per frame
	void Update () {

		text.text = "Lights: " + items;



	}
}

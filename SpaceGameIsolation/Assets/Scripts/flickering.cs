using UnityEngine;
using System.Collections;

public class flickering : MonoBehaviour {


	public Material mat;

	// Use this for initialization
	void Start () {
	
		mat = GetComponent<Renderer>().material;

	}
	
	// Update is called once per frame
	void Update () {
	
		//Color colour = new Color(mat.color.r,mat.color.g,mat.color.b, Random.Range (0, 255));

		//mat.color = colour;
		//mat.mainTexture.
		//GetComponent<Renderer>().material.SetTexture(displayTexture);
	}
}

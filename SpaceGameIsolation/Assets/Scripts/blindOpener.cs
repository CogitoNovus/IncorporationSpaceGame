using UnityEngine;
using System.Collections;

public class blindOpener : MonoBehaviour {

	public bool open;
	public float t;
	public Transform point;
	public Vector3 pos;
	public float speed;

	// Use this for initialization
	void Start () {
		pos = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (open == true && t<1) {
			t += speed;
		} else if (open == false && t>0) {
			t-= speed;
		}

		transform.position = Vector3.Lerp(pos, point.position, t);
	}
}

using UnityEngine;
using System.Collections;

public class DrillRotation : MonoBehaviour {
	
	public float x=0;
	public GameObject[] drillLaser;
	public ParticleSystem[] part;
	public float[] rate;
	public Light DLight;
	public LensFlare DFlare;
	public float intenDLight;
	public float rangeDLight;
	private float flarion;

	// Use this for initialization
	void Start () {

		for(int i=0; i<4; i++){
		part[i] = drillLaser[i].GetComponent<ParticleSystem>();
		rate[i] = part[i].emissionRate;
		}
	
		DLight = drillLaser[4].GetComponent<Light>();
		DFlare = drillLaser[4].GetComponent<LensFlare>();
		flarion = DFlare.brightness;
		rangeDLight = DLight.range;
		intenDLight = DLight.intensity;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButton ("Fire1") && x<5) {
			x = x + 0.1f + 0.05f * x;
				} else {
			if(x>0){
			x= x-0.09f;
			}
				}
		if (x < 0) {
			x=0;
				}


		if (x > 4) {
			for(int i = 0; i<4; i++){
			part[i].emissionRate = rate[i];
			}
			DFlare.brightness = flarion;
			DLight.intensity = intenDLight;
			DLight.range = rangeDLight;

				} else {
			for(int i = 0; i<4; i++){
			part[i].emissionRate = 0;
				DLight.range = 0;
				DLight.intensity = 0;
				DFlare.brightness = 0;
			}
			//part.emissionRate = 0;
				}

		transform.Rotate (Vector3.up*x);

	}
}

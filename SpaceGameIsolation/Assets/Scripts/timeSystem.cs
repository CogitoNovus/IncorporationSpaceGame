using UnityEngine;
using System.Collections;
using UnityStandardAssets;

public class timeSystem : MonoBehaviour {

	public float seconds;
	public int minutes;
	public int hours;
	public int days;

	public GameObject blur;

	public static float constitution;

	public string minutesText;
	public string hoursText;

	//public MonoBehaviour blurIte;

	public UnityStandardAssets.ImageEffects.BlurOptimized blurIte;

	//public UnityStandardAssets.ImageEffects.TiltShift blurIte;

	static public bool awake;

	// Use this for initialization
	void Start () {

		blurIte = blur.GetComponent<UnityStandardAssets.ImageEffects.BlurOptimized>();
		constitution = 1000;
		seconds = 0;
		minutes = 0;
		hours = 0;
		days = 1;
		awake = true;
	}
	
	// Update is called once per frame
	void Update () {
	
		Debug.Log(constitution);

		if (awake == true){

			seconds += 1*Time.deltaTime;
			constitution -= 1*Time.deltaTime;
		}

		//If Statements regarding time

		if (seconds >= 60){

			seconds = 0;
			minutes++;
		}

		if (minutes == 60){

			minutes = 0;
			hours++;
		}

		if (hours == 24){

			hours = 0;
			days++;
		}

		if (minutes < 10){

			minutesText = "0" + minutes.ToString();
		}

		if (minutes > 10){

			minutesText = minutes.ToString();
		}

		if (hours < 10){

			hoursText = "0" + hours.ToString();
		}

		if (hours > 10){
			
			hoursText = hours.ToString();
		}

		GetComponent<TextMesh>().text = "Day: " + days.ToString() + "\nTime: " + hoursText + ":" + minutesText;

		if (constitution < 500)	{

			blurIte.enabled = true;

		}

	
		if (constitution < 300)	{

			blurIte.blurIterations = 2;
		}

		if (constitution < 100)	{
			
			blurIte.blurIterations = 3;
			
		}

		if (constitution < 50)	{
			
			blurIte.blurIterations = 4;
			
		}
	}
}

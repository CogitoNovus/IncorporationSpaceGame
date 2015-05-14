using UnityEngine;
using System.Collections;
using UnityStandardAssets;

public class timeSystem : MonoBehaviour {

	//Time
	public float seconds;
	public int minutes;
	public int hours;
	public int days;

	//Camera
	public Camera main;
	public Camera black;

	//Blur
	public GameObject blur;
	public UnityStandardAssets.ImageEffects.BlurOptimized blurIte;
	
	//Constituion
	public float constitution;

	//Strings
	public string minutesText;
	public string hoursText;

	//Bool
	static public bool awake;

	//Int
	public int tiredLvl;

	// Use this for initialization
	void Start () {

		blurIte = blur.GetComponent<UnityStandardAssets.ImageEffects.BlurOptimized>();
		constitution = 1000;
		seconds = 0;
		minutes = 0;
		hours = 0;
		days = 1;
		awake = true;
		black.enabled = false;
		tiredLvl = 0;

	}
	
	// Update is called once per frame
	void Update () {

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

		if (hours >= 24){

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

		if (constitution > 500) {

			blurIte.enabled = false;
			tiredLvl = 0;
		}

		if (constitution < 500)	{

			blurIte.enabled = true;
			blurIte.blurIterations = 1;
			tiredLvl = 1;
		}

		//If Statements regarding constitution
		if (constitution < 300)	{

			blurIte.blurIterations = 2;
			tiredLvl = 2;
		}

		if (constitution < 100)	{
			
			blurIte.blurIterations = 3;
			tiredLvl = 3;
			
		}

		if (constitution < 50)	{
			
			blurIte.blurIterations = 4;
			tiredLvl = 4;
		}

		if (awake == false){

			StartCoroutine(Sleep());
		}
	}

	IEnumerator Sleep() {

		main.enabled = false;
		black.enabled = true;

		yield return new WaitForSeconds(3);

		if (tiredLvl == 1){

			hours = hours + 8;
		}

		if (tiredLvl == 2){
			
			hours = hours + 10;
		}

		if (tiredLvl == 3){
			
			hours = hours + 12;
		}

		if (tiredLvl == 4){
			
			hours = hours + 14;
		}

		tiredLvl = 0;

		constitution = 1000;
		awake = true;

		main.enabled = true;
		black.enabled = false;

	}
}

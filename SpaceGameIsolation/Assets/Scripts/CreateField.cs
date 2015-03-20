using UnityEngine;
using System.Collections;

public class CreateField : MonoBehaviour
{

		public GameObject asteroid;

		public GameObject[] asteroidSpawn;
		
		private int i;

		
		// Use this for initialization
		void Start ()
		{


				for (int x = 0; x < 200; x += 30) {
			i++;
						for (int y = 0; y < 200; y += 30) { 
								for (int z = 0; z < 200; z += 30) {
				
										int r = Random.Range (1, 5);
										if (r == 4) {
												//GameObject asteroidSpawn;
			
						asteroidSpawn[i] = Instantiate (asteroid, new Vector3 (transform.position.x + x, transform.position.y + y, transform.position.z + z), new Quaternion (Random.Range (0, 360), Random.Range (0, 360), Random.Range (0, 360), Random.Range (0, 360))) as GameObject;
			
												int t = Random.Range (0, 10);

												int m = Random.Range (0, 10);

												if (m == 7){

												asteroidSpawn[i].tag = "Mineral";
												
												}
												else {

												asteroidSpawn[i].tag = "Untagged";					

												}
												
												if (t == 7) {

												asteroidSpawn[i].GetComponent<Rigidbody>().AddForce (new Vector3 (Random.Range (0, 360), Random.Range (0, 360), Random.Range (0, 360))*50);
														//asteroidSpawn = Instantiate (asteroid, new Vector3 (x+0.5f, y, z), new Quaternion (Random.Range (0, 360), Random.Range (0, 360), Random.Range (0, 360), Random.Range (0, 360))) as GameObject;
												}
												asteroidSpawn[i].GetComponent<Rigidbody>().AddForce (new Vector3 (Random.Range (0, 360), Random.Range (0, 360), Random.Range (0, 360)));

												int scale = Random.Range (1, 18);
												asteroidSpawn[i].transform.localScale = new Vector3 (scale, scale, scale);

												asteroidSpawn[i].GetComponent<Rigidbody>().AddTorque (new Vector3 (Random.Range (0, 10), Random.Range (0, 10), Random.Range (0, 10)));
										}
								}
						}
				}
		}
	
		// Update is called once per frame
		void Update ()
		{

		}

	/*
	    void OnTriggerEnter(Collider other)
		{
			if(other.transform.tag == "Player"){

				Debug.Log("HE'S IN!!");
				Asteroid.visible = true;
			}
		}
		
		void OnTriggerExit(Collider other)
		{
			if(other.transform.tag == "Player"){

				Debug.Log("HE'S NOT IN!!!?!");
				Asteroid.visible = false;
		}*/
}

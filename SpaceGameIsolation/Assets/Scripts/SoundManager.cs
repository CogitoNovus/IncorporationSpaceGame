using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioClip[] clips;

	public AudioSource[] sources;

	public AudioSource AudioPlayer;	

	/*public AudioClip throttleStart;

	public AudioClip throttleLoop;	

	public AudioClip drilling;

	private AudioSource AuSo;*/

	/*
	Use these two sentences to play sound:
	
	GameObject g = GameObject.Find("Sound Manager");
	
	g.GetComponent<SoundManager>().Player(2);*/

	void Start () {

		for(int i = 0; i < clips.Length; i++){

			sources[i] = Instantiate(AudioPlayer, transform.position, Quaternion.identity) as AudioSource;

			sources[i].clip = clips[i];
		}
	}

	// Update is called once per frame
	void Update () {
	
	/*AuSo = GetComponent<AudioSource>();
	
	//Throttle
	if (Input.GetKeyDown(KeyCode.Space)){

	Player(1);

		}
	AuSo.PlayOneShot(throttleStart, 1f);
	AuSo.clip = throttleLoop;
	AuSo.loop = true;
	AuSo.Play();
		}

	if (Input.GetKeyUp(KeyCode.Space)){

	AuSo.Stop();
	AuSo.loop = false;
		}*/
	
	
	
	//Drilling
	/*if (Input.GetMouseButtonDown(0) && Avatar.drill == true){

	AuSo.clip = drilling;
	AuSo.loop = true;
	AuSo.Play();
		}

	if (Avatar.drill == false && Input.GetMouseButtonUp(0) || PlayerResource.energyLvl == 1){
	
	AuSo.Stop();
	AuSo.loop = false;
		}*/

	}

 public void Player(int i){

		sources[i].Play();
	}
}

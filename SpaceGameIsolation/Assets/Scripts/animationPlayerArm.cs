using UnityEngine;
using System.Collections;

public class animationPlayerArm : MonoBehaviour {

	public bool Idle;
	private Animation a;
	public bool BreadcrumbIdle;
	private Animator anima;

	// Use this for initialization
	void Start () {
		a = gameObject.GetComponent<Animation>();
		Idle = true;
		anima = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Idle==true) {
		Idling ();
				}

		if (Input.GetButtonDown ("Fire1")) {
			Idle=false;
			breadcrumbEquip();		
		}

	}

	void Idling(){
		a.wrapMode = WrapMode.Loop;
		a.Play ("idle");
		//Idle = true;
	}

	void breadcrumbEquip(){
		a["breadcrumbEquip"].wrapMode = WrapMode.Once;
		a.Play ("breadcrumbequip");
		if (anima.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !anima.IsInTransition(0)){
			a["breadcrumbIdle"].wrapMode = WrapMode.Loop;
			a.Play("breadcrumbIdle");
			BreadcrumbIdle=true;
		}
	}

		}


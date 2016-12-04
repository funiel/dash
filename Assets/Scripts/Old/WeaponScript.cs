using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {

	Animator anim; 

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update() {
		if (Input.GetMouseButton (0)) {
			anim.SetTrigger ("Attack");
		}
	}
}

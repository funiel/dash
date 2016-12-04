using UnityEngine;
using System.Collections;

public class PlayerMobility : MonoBehaviour {

	public float speed;
	//Animator anim;

	//void Start()
	//{
	//	anim = GetComponent<Animator> ();
	//}

	//void Update()
	//{
	//	if (Input.GetMouseButtonDown (0)) {
	//		anim.SetTrigger ("Attack");
	//	}
	//}

	void FixedUpdate()
	{
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

		transform.rotation = rot;
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		GetComponent<Rigidbody2D>().angularVelocity = 0;

		float input = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().AddForce (gameObject.transform.up * speed * input);

		float input2 = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().AddForce (gameObject.transform.right * speed * input);

	}

}

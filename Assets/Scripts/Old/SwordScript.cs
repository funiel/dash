using UnityEngine;
using System.Collections;

public class SwordScript : MonoBehaviour {

	public GameObject explosion;
	public GameObject weapon;

	void OnTriggerEnter2D(Collider2D other)
	{
		Instantiate(explosion, other.transform.position, Quaternion.identity);
		Destroy (other.gameObject);
	}

	//void Update() {
	//
	//	if (Input.GetMouseButtonDown (1)) {
	//		GameObject go = (GameObject)Instantiate(weapon);
	//	}
	//}

}

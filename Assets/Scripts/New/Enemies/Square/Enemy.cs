using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

	public float speed;
	public Transform player;

    void Start() {
        player = (GameObject.Find("Player")).transform;
    }

	void FixedUpdate ()
	{
		float z = Mathf.Atan2 ((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;
		transform.eulerAngles = new Vector3 (0, 0, z);

		GetComponent<Rigidbody2D>().AddForce (gameObject.transform.up * speed);
	
	}

	//void OnCollisionEnter2D(Collision2D other){
	//	if (other.gameObject.name == "player") {
	//		SceneManager.LoadScene ("Testisgut");
	//	}
	//}
}
	

using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] platformPrefabs;
	GameObject platformPrefab;
	private void SpawnPlatform(){
		if(platformPrefabs == null || platformPrefabs.Length < 1){
			return;
		}

		platformPrefab = platformPrefabs[Random.Range(0, platformPrefabs.Length)];
		Vector3 newPos = new Vector3 (3.5f, 1.8f, 0f);
		GameObject octo = Instantiate (platformPrefab, newPos, Quaternion.identity) as GameObject;
	}
}

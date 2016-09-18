using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	AsteroidSpawner asteroidSpawner;

	// Use this for initialization
	void Start () {
		asteroidSpawner = GetComponent<AsteroidSpawner> ();
		for (int i = 0; i < 6; i++) {
			asteroidSpawner.spawnAsteroid ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

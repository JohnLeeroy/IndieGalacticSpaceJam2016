using UnityEngine;
using System.Collections.Generic;

public class AsteroidSpawner : MonoBehaviour {

	public Transform[] spawnTransforms;
	public GameObject[] asteroidPrefabs;
	private List<SpawnPoint> spawnPoints;

	public GameObject[] buildingPrefabs;
	BuildingFactory buildingFactory;

	void Start() {
		buildingFactory = GetComponent<BuildingFactory> ();
		spawnPoints = new List<SpawnPoint> ();
		foreach (Transform tf in spawnTransforms) {
			SpawnPoint spawnPoint = new SpawnPoint ();
			spawnPoint.transform = tf;
			spawnPoint.isVacant = true;
			spawnPoints.Add (spawnPoint);
		}
	}

	public void spawnAsteroid() {
		foreach (SpawnPoint spawnPoint in spawnPoints) {
			if (spawnPoint.isVacant) {
				spawnPoint.isVacant = false;
				int prefabIndex = Random.Range (0, asteroidPrefabs.Length);
				GameObject asteroidGO = (GameObject) Instantiate (asteroidPrefabs [prefabIndex], spawnPoint.transform.position, Quaternion.identity);
				Asteroid asteroid = asteroidGO.GetComponent<Asteroid> ();
				foreach (GameObject prefab in buildingPrefabs) {
					GameObject building = buildingFactory.instantiateBuilding (asteroid, prefab);
					asteroid.addBuilding (building);
				}
			}
		}
	}

	public class SpawnPoint {
		public Transform transform;
		public bool isVacant;
	}
}

using UnityEngine;
using System.Collections;

public class BuildingFactory : MonoBehaviour {

	public GameObject instantiateBuilding(Asteroid asteroid, GameObject prefab) {
		Transform tf = asteroid.transform;
		GameObject building = (GameObject)GameObject.Instantiate(prefab, tf.position, Quaternion.identity);
		building.transform.SetParent (tf);
		return building;
	}
}

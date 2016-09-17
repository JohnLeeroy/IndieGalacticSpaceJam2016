using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float resource;

	public GameObject onPurchaseComplete(GameObject prefab, float cost) {
		resource -= cost;
		return prefab;
	}
}

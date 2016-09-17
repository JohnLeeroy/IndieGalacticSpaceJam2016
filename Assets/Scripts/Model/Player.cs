using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float money;

	public GameObject onPurchaseComplete(GameObject prefab, float cost) {
		money -= cost;
		return prefab;
	}
}

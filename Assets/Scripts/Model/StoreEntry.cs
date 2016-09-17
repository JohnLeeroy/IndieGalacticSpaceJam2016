using UnityEngine;
using System.Collections;

public class StoreEntry {
	public GameObject prefab;
	public BaseUnit unit;

	public StoreEntry(GameObject prefab, BaseUnit unit) {
		this.prefab = prefab; 
		this.unit = unit;
	}
}

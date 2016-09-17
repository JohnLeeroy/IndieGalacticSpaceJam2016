using UnityEngine;
using System.Collections;

public class Silo : MonoBehaviour, ICost, ICapacity {

	public float cost;
	public float capacity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public float GetCapacity() {
		return capacity;
	}

	public float GetCost() {
		return cost;
	}
}

using UnityEngine;
using System.Collections;

public class Freighter : BaseUnit, ICapacity {

	Engine engine;

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
}

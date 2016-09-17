using UnityEngine;
using System.Collections;

public abstract class BaseBuilding : BaseUnit {

	public int size;
	public float powerConsumption = 10;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public int getSize() {
		return size;
	}

}

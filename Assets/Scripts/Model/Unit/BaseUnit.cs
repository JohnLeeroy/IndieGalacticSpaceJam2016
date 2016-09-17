using UnityEngine;
using System.Collections;

public abstract class BaseUnit : MonoBehaviour, ICost {

	public int buildCost;

	public string unitName;

	public string description;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public float GetCost() {
		return buildCost;
	}

	public abstract int getUnitTypeId();
}

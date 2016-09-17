using UnityEngine;
using System.Collections;

public abstract class BaseUnit : MonoBehaviour, ICost, ICapacity {

	public int buildCost;

	public string unitName;

	public string description;

	public int size;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public virtual int GetCostType() {
		return -1;
	}

	public float GetCost() {
		return buildCost;
	}

	public int GetSize() {
		return size;
	}

	public abstract int getUnitTypeId();
}

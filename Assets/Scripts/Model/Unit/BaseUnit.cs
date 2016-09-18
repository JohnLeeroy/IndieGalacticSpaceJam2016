using UnityEngine;
using System.Collections;

public abstract class BaseUnit : MonoBehaviour, ICost, ICapacity {

	public int buildCost;

	public string unitName;

	public string description;

	public int size;

	public float powerConsumption = 10;

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

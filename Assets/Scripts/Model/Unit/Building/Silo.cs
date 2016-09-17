using UnityEngine;
using System.Collections;

public class Silo : BaseBuilding {

	public float capacity;	

	public float GetCapacity() {
		return capacity;
	}

	override public int GetCostType() {
		return Constants.COST_TYPE_MATERIALS;
	}

	override public int getUnitTypeId() {
		return Constants.SILO_TYPE_ID;
	}
}

using UnityEngine;
using System.Collections;

public class Silo : BaseBuilding {

	public float capacity;	

	public float GetCapacity() {
		return capacity;
	}

	public virtual int GetCostType() {
		return Constants.COST_TYPE_MATERIALS;
	}

	override public int getUnitTypeId() {
		return 937562; //random
	}
}

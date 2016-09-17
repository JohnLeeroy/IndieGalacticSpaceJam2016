using UnityEngine;
using System.Collections;

public class SolarCollector : BaseBuilding {

	public float powerCapacity = 100; 


	public virtual int GetCostType() {
		return Constants.COST_TYPE_MATERIALS;
	}

	override public int getUnitTypeId() {
		return 837123; //random
	}
}

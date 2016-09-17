using UnityEngine;
using System.Collections;

public class SolarCollector : BaseBuilding {

	public float powerCapacity = 100; 


	override public int GetCostType() {
		return Constants.COST_TYPE_MATERIALS;
	}

	override public int getUnitTypeId() {
		return Constants.SOLAR_COLLECTOR_TYPE_ID;
	}
}

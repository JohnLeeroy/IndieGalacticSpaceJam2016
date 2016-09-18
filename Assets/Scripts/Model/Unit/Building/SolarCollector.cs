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

	override public void recalculateStats () {

	}

	override public int getRobotsNeeded () {
		const int baseRobots = 1;
		return baseRobots;
	}

	override public int getPowerNeeded () {
		const int powerConsumption = 0;
		return powerConsumption;
	}

	override public int getAreaNeeded () {
		const int spaceUsed = 20;
		//TODO Check level
		return spaceUsed;

	}

	override public int getMaterialNeeded () {
		const int baseCost = 30;
		return baseCost;
	}
}

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

	override public void recalculateStats () {

	}

	override public int getRobotsNeeded () {
		const int baseRobots = 1;
		return baseRobots;
	}

	override public int getPowerNeeded () {
		const int powerConsumption = 6;
		return powerConsumption;
	}

	override public int getAreaNeeded () {
		const int spaceUsed = 15;
		//TODO Check level
		return spaceUsed;

	}

	override public int getMaterialNeeded () {
		const int baseCost = 20;
		return baseCost;
	}
}

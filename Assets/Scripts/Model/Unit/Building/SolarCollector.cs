using UnityEngine;
using System.Collections;

public class SolarCollector : BaseBuilding {

	public float powerCapacity = 100; 

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter.AddObserver (this, "recalculateStats");
	}

	override public int GetCostType() {
		return Constants.COST_TYPE_MATERIALS;
	}

	override public int getUnitTypeId() {
		return Constants.SOLAR_COLLECTOR_TYPE_ID;
	}

	override public void recalculateStats () {
		powerConsumption = getPowerNeeded();
		size = getAreaNeeded ();
		robotCost = getRobotsNeeded ();
		buildCost = getMaterialNeeded ();
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

using UnityEngine;
using System.Collections;

public class LaunchPad : BaseBuilding {

	int maxCarriers = 1;
	int carrierCount = 0;

	float sendCargoRate = 100;
	float carrierCapacity;
	float carrierCost;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	override public int GetCostType() {
		return Constants.COST_TYPE_MATERIALS;
	}

	override public int getUnitTypeId() {
		return Constants.LAUNCH_PAD_TYPE_ID;
	}

	override public void recalculateStats () {

	}

	override public int getRobotsNeeded () {
		const int baseRobots = 1;
		return baseRobots;
	}

	override public int getPowerNeeded () {
		const int powerConsumption = 9;
		return powerConsumption;
	}

	override public int getAreaNeeded () {
		const int spaceUsed = 10;
		//TODO Check level
		return spaceUsed;

	}

	override public int getMaterialNeeded () {
		const int baseCost = 45;
		return baseCost;
	}

}

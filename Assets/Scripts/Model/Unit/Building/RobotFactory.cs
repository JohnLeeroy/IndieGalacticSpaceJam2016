using UnityEngine;
using System.Collections;

public class RobotFactory : BaseBuilding {

	public int robotCount = 5;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter.AddObserver (this, "recalculateStats");
	}

	override public int GetCostType() {
		return Constants.COST_TYPE_MATERIALS;
	}

	override public int getUnitTypeId() {
		return Constants.ROBOT_FACTORY_TYPE_ID;
	}

	override public void recalculateStats () {

	}

	override public int getRobotsNeeded () {
		const int baseRobots = 0;
		return baseRobots;
	}

	override public int getPowerNeeded () {
		const int powerConsumption = 12;
		return powerConsumption;
	}

	override public int getAreaNeeded () {
		const int spaceUsed = 7;
		//TODO Check level
		return spaceUsed;

	}

	override public int getMaterialNeeded () {
		const int baseCost = 40;
		return baseCost;
	}

}

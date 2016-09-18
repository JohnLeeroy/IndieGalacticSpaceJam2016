using UnityEngine;
using System.Collections;

public class Drill : BaseBuilding {

	public float damage = 10;
	public float rateOfAttack = 1;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter.AddObserver (this, "recalculateStats");
	}
	
	// Update is called once per frame
	void Update () {
		asteroid.Drill (damage * rateOfAttack * Time.deltaTime);
	}

	override public int GetCostType() {
		return Constants.COST_TYPE_MATERIALS;
	}

	override public int getUnitTypeId() {
		return Constants.DRILL_TYPE_ID;
	}

	override public void recalculateStats () {
		
	}

	override public int getRobotsNeeded () {
		const int baseRobots = 1;
		return baseRobots;
	}

	override public int getPowerNeeded () {
		const int powerConsumption = 15;
		return powerConsumption;
	}

	override public int getAreaNeeded () {
		const int spaceUsed = 5;
		//TODO Check level
		return spaceUsed;

	}

	override public int getMaterialNeeded () {
		const int baseCost = 25;
		return baseCost;
	}
}

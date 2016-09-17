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
}

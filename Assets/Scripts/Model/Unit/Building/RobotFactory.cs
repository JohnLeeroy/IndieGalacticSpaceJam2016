using UnityEngine;
using System.Collections;

public class RobotFactory : BaseBuilding {

	public int robotCount;

	// Use this for initialization
	void Start () {
		
	}

	override public int GetCostType() {
		return Constants.COST_TYPE_MATERIALS;
	}

	override public int getUnitTypeId() {
		return Constants.ROBOT_FACTORY_TYPE_ID;
	}
}

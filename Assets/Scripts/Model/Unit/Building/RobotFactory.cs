using UnityEngine;
using System.Collections;

public class RobotFactory : BaseBuilding {

	Drill drill;

	// Use this for initialization
	void Start () {
		drill = GetComponent<Drill>();
	}

	override public int GetCostType() {
		return Constants.COST_TYPE_MATERIALS;
	}

	override public int getUnitTypeId() {
		return Constants.ROBOT_FACTORY_TYPE_ID;
	}
}

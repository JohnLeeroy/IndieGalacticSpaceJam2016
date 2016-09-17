using UnityEngine;
using System.Collections;

public class RobotFactory : BaseBuilding {

	Drill drill;

	// Use this for initialization
	void Start () {
		drill = GetComponent<Drill>();
	
	}

	public virtual int GetCostType() {
		return Constants.COST_TYPE_MATERIALS;
	}

	override public int getUnitTypeId() {
		return 495673; //random
	}
}

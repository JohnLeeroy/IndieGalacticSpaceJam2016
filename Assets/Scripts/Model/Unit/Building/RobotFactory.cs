using UnityEngine;
using System.Collections;

public class RobotFactory : BaseBuilding {

	Drill drill;

	// Use this for initialization
	void Start () {
		drill = GetComponent<Drill>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	override public int getUnitTypeId() {
		return 495673; //random
	}
}

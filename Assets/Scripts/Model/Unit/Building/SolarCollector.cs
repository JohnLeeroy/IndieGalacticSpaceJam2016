using UnityEngine;
using System.Collections;

public class SolarCollector : BaseBuilding {

	public float powerCapacity = 100; 

	override public int getUnitTypeId() {
		return 837123; //random
	}
}

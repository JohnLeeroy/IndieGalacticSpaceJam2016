using UnityEngine;
using System.Collections;

public class Freighter : BaseUnit, ICapacity {

	Engine engine;

	public float capacity; 

	public float GetCapacity() {
		return capacity;
	}

	override public int getUnitTypeId() {
		return 3425236; //random
	}
}

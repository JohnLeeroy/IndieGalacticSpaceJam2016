using UnityEngine;
using System.Collections;

public class Freighter : BaseUnit {

	Engine engine;

	public float cargoAmount;

	override public int getUnitTypeId() {
		return 3425236; //random
	}
}

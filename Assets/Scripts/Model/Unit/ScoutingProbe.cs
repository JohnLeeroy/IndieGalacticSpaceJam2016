using UnityEngine;
using System.Collections;

public class ScoutingProbe : BaseUnit {

	Engine engine;

	// Use this for initialization
	void Start () {
		engine = GetComponent<Engine>();
	}

	override public int getUnitTypeId() {
		return 57395; //random
	}
}

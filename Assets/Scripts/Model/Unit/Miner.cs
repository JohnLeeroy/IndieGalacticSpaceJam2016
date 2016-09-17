using UnityEngine;
using System.Collections;

public class Miner : BaseUnit {
	
	Engine engine;
	Drill drill;

	// Use this for initialization
	void Start () {
		engine = GetComponent<Engine>();
		drill = GetComponent<Drill> ();
	}

	override public int getUnitTypeId() {
		return 1358123; //random
	}
}

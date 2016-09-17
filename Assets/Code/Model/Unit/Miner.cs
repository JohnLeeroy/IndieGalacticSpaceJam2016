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

	// Update is called once per frame
	void Update () {
	
	}
}

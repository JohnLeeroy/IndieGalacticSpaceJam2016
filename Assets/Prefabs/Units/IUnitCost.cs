using UnityEngine;
using System.Collections;

public interface IUnitCost {

	int getRobotsNeeded();
	int getPowerNeeded();
	int getAreaNeeded();
	int getMaterialNeeded();
}

/*
  Building Name: Robots / Power / Space / Unique Units / Silicaceous Ore
	Robotics Facility: 0 / 12 / 7 / 5 / 40
	Solar Farm: 1 / 0 / 20 / 50 / 30
	Drill: 1 / 15 / 5 / 1 / 25
	Storage: 1 / 6 / 15 / 300 / 20
	Launch Pad: 1 / 9 / 10 / -500 / 45
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Asteroid : MonoBehaviour {

	public List<BaseBuilding> buildings = new List<BaseBuilding>();

	public int totalPowerCapacity;
	public int totalPowerConsumption;

	public int buildingCapacityUsed;
	public int buildingCapacity;

	public int robotCount;
	public int robotsNeeded;

	//Resources
	public float materials = 1000;	// silicaceous
	public float fuel = 1000;		// carbonaceous
	public float sellableMaterial = 1000;		// Metallic


	public bool hasCapacity(int targetBuildingSize) {
		return (buildingCapacityUsed + targetBuildingSize) < buildingCapacity;
	}

	public void addBuilding(GameObject building) {
		BaseBuilding buildingComponent = building.GetComponent<BaseBuilding> ();
		buildingComponent.setAsteroid(this);
		buildings.Add (buildingComponent);
		buildingCapacityUsed += buildingComponent.GetSize ();
	}

	public void Drill(float amount) {
		materials += amount;
		fuel += amount;
		sellableMaterial += amount;
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Asteroid : MonoBehaviour {

	public List<BaseBuilding> buildings = new List<BaseBuilding>();

	public int baseBuildingCapacity;
	public float baseMaterialCapacity;
	public float basePowerCapacity;
	public int baseRobotCount;

	public float totalPowerCapacity;
	public float totalPowerConsumption;

	public int buildingCapacityUsed;
	public int buildingCapacity;

	public int robotCount;
	public int robotUsed;

	public float materialCapacity;

	//Resources
	public float materials = 1000;	// silicaceous
	public float fuel = 1000;		// carbonaceous
	public float sellableMaterial = 1000;		// Metallic

	void Start() {
		recalculateStats ();
	}

	public bool hasCapacity(int targetBuildingSize) {
		return (buildingCapacityUsed + targetBuildingSize) <= buildingCapacity;
	}

	public bool hasPower(float targetPowerAddition) {
		return (totalPowerConsumption + targetPowerAddition) <= totalPowerCapacity;
	}

	public bool hasRobots(int robotCost) {
		return (robotUsed + robotCost) <= robotCount;

	}

	public void addBuilding(GameObject building) {
		BaseBuilding buildingComponent = building.GetComponent<BaseBuilding> ();
		buildingComponent.setAsteroid(this);
		buildings.Add (buildingComponent);
		buildingCapacityUsed += buildingComponent.GetSize ();

		recalculateStats ();
	}

	public void recalculateStats() {
		totalPowerConsumption = 0;
		buildingCapacityUsed = 0;
		robotUsed = 0;

		robotCount = baseRobotCount;
		totalPowerCapacity = basePowerCapacity;
		buildingCapacity = baseBuildingCapacity;
		materialCapacity = baseMaterialCapacity;

		foreach (BaseBuilding building in buildings) {
			buildingCapacityUsed += building.GetSize ();
			totalPowerConsumption += building.powerConsumption;
			robotUsed += 1; //TODO?
			switch (building.getUnitTypeId ()) {
				case Constants.SOLAR_COLLECTOR_TYPE_ID:
					totalPowerCapacity += ((SolarCollector)building).powerCapacity;
					break;
				case Constants.SILO_TYPE_ID:
					materialCapacity += ((Silo)building).capacity;
				break;
			case Constants.ROBOT_FACTORY_TYPE_ID:
				RobotFactory factory = (RobotFactory)building;
				robotCount += factory.robotCount;
				break;
			}	
		}
	}

	public void Drill(float amount) {
		materials = Mathf.Min (materials + amount, materialCapacity);
		fuel =  Mathf.Min (fuel + amount, materialCapacity);
		sellableMaterial =  Mathf.Min (sellableMaterial + amount, materialCapacity);
	}
}

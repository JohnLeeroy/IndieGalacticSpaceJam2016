using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Asteroid : MonoBehaviour {

	public List<BaseBuilding> buildings = new List<BaseBuilding>();

	public string asteroidName;

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

	//When sellable material is at 500 check to see if you have enough fuel which should be above 500. Then remove 500 sellable material and 500 fuel from the astroid.
	//When freighter hits earth, earth gains $500x100


	//Resources
	public float materials = 1000;	// silicaceous
	public float fuel = 1000;		// carbonaceous
	public float sellableMaterial = 1000;		// Metallic

	/*
		Concept
		The first rocket from Earth to an asteroid was funded by VC.  We have no money at this point and need a “starter kit” to get us going.  This kit will contain 4 of our 5 buildings.
		Components
		1 Solar Farm, 1 Drill, 1 Storage, & 1 Robotics Facility
		Characteristics
		This will provide immediate income
		This will provide 2 extra robots for our next 2 buildings
		This will provide 17 extra units of power for our next building(s)
	*/
	void Start() {
		
		recalculateStats ();
		asteroidName = AsteroidNames.Instance.getNextAsteroidName ();
	}

	void Update () {
		if(sellableMaterial >= 500.0){
			if(fuel >= 500.0){
				
				sellableMaterial -= 500;
				fuel -= 500;
				//Spawn the freighter
				GameObject freighter = (GameObject)Instantiate (Resources.Load("FreighterPrefab"), transform.position, Quaternion.identity);


				//Give the freighter Currency, Right now it's just 1:1, modification to come.
				freighter.GetComponent<FreighterController>().UpdateCurrency(500);

				//Give the spawned ship the Vector2 location of the Astrod it's traveling to. 
				freighter.GetComponent<FreighterController>().moveToLocation = new Vector2(0,0); 

			}	
		}


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

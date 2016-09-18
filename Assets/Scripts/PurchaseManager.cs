using UnityEngine;
using System.Collections;

public class PurchaseManager : MonoBehaviour {

	public Player customer;
	public Store store;			//Can be an asteroid

	BuildingFactory factory;

	void Start() {
		factory = GetComponent<BuildingFactory> ();
	}

	public void PurchaseUpgrade(int upgradeId) {

	}

	public void Purchase(int unitTypeId) {
		StoreEntry storeEntry = store.getStoreEntry(unitTypeId);
		Asteroid asteroid = store.asteroid;
		int unitType = storeEntry.unit.getUnitTypeId ();
		bool hasSpace = asteroid.hasCapacity (storeEntry.unit.GetSize ());
		if (!hasSpace) {
			print ("Not enough space on the asteroid to build " + storeEntry.unit.unitName);
			return;
		}

		bool hasEnergy = asteroid.hasPower (storeEntry.unit.powerConsumption);
		if (unitType != Constants.SOLAR_COLLECTOR_TYPE_ID && !hasEnergy) {
			print ("Not enough energy on the asteroid to build " + storeEntry.unit.unitName);
			return;
		}

		bool hasRobot = asteroid.hasRobots (1);
		print("Type : " + unitType + "  |  " + Constants.ROBOT_FACTORY_TYPE_ID);
		if (unitType != Constants.ROBOT_FACTORY_TYPE_ID && !hasRobot) {
			print ("Not enough robots on the asteroid to build " + storeEntry.unit.unitName);
			return;
		}

		bool hasEnoughResource = false;
		float cost = storeEntry.unit.GetCost ();
		switch (unitType) {
		case Constants.COST_TYPE_FUEL: 
			if (asteroid.fuel > cost) {
				asteroid.fuel -= cost;
				hasEnoughResource = true;
			}
			break;
		case Constants.COST_TYPE_MATERIALS: 
			if (asteroid.materials > cost) {
				asteroid.materials -= cost;
				hasEnoughResource = true;
			}

			break;
		case Constants.COST_TYPE_SELLABLE: 
			if (asteroid.sellableMaterial > cost) {
				asteroid.sellableMaterial -= cost;
				hasEnoughResource = true;
			}
			break;
		}
		if (hasEnoughResource) {
			print("Purchase item " + unitTypeId);
			GameObject building = factory.instantiateBuilding (asteroid, storeEntry.prefab);
			asteroid.addBuilding (building);
			//Spawn on that asteroid
		} else {
			print ("Cant buy " + storeEntry.unit.unitName + ". Not enough resource.");
		}
	}
}

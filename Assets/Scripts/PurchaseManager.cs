using UnityEngine;
using System.Collections;

public class PurchaseManager : MonoBehaviour {

	public Player customer;
	public Store store;			//Can be an asteroid

	BuildingFactory factory;

//	public void Purchase(BaseUnit unit) {
//		float cash = customer.resource;
//		if (cash > unit.GetCost ()) {
//			StoreEntry storeEntry = store.Purchase (unit);
//			customer.onPurchaseComplete (storeEntry.prefab, unit.GetCost());
//			//spawn unit
//
//		}
//	}

	void Start() {
		factory = GetComponent<BuildingFactory> ();
	}

	public void PurchaseUpgrade(int upgradeId) {

	}

	public void Purchase(int unitTypeId) {
		StoreEntry storeEntry = store.getStoreEntry(unitTypeId);
		Asteroid asteroid = store.asteroid;

		bool hasSpace = asteroid.hasCapacity (storeEntry.unit.GetSize ());
		if (!hasSpace) {
			print ("Not enough space on the asteroid to build " + storeEntry.unit.unitName);
			return;
		}
		bool hasEnoughResource = false;
		float cost = storeEntry.unit.GetCost ();
		switch (storeEntry.unit.GetCostType()) {
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

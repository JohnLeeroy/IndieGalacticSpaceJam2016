using UnityEngine;
using System.Collections;

public class PurchaseManager : MonoBehaviour {

	public Player customer;
	public Store store;			//Can be an asteroid

//	public void Purchase(BaseUnit unit) {
//		float cash = customer.resource;
//		if (cash > unit.GetCost ()) {
//			StoreEntry storeEntry = store.Purchase (unit);
//			customer.onPurchaseComplete (storeEntry.prefab, unit.GetCost());
//			//spawn unit
//
//		}
//	}

	public void PurchaseUpgrade(int upgradeId) {

	}

	public void Purchase(int unitTypeId) {
		StoreEntry storeEntry = store.getStoreEntry(unitTypeId);
		Asteroid asteroid = store.asteroid;
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
			//Spawn on that asteroid
		} else {
			print ("Cant buy " + storeEntry.unit.unitName + ". Not enough resource.");
		}
	}
}

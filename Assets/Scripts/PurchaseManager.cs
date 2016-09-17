using UnityEngine;
using System.Collections;

public class PurchaseManager : MonoBehaviour {

	public Player customer;
	public Store store;			//Can be an asteroid

	public void Purchase(BaseUnit unit) {
		float cash = customer.resource;
		if (cash > unit.GetCost ()) {
			StoreEntry storeEntry = store.Purchase (unit);
			customer.onPurchaseComplete (storeEntry.prefab, unit.GetCost());
			//spawn unit

		}
	}

	public void Purchase(int unitTypeId) {
		//todo get check if player has the cash
		//float cash = customer.resource;
		//StoreEntry storeEntry = store.Purchase (unitTypeId);
		//customer.onPurchaseComplete (storeEntry.prefab, storeEntry.unit.GetCost());
		print("Purchase item " + unitTypeId);
	}
}

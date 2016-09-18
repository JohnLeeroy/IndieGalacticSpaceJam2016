using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PurchaseUI : MonoBehaviour {

	public PurchaseManager purchaseManager;

	public IList<StoreEntry> storeEntries;

	public PurchaseButton[] button;

//	void Start() {
//		
//		storeEntries = new List<StoreEntry>(purchaseManager.store.storeEntries.Values);
//		for (int i = 0; i < storeEntries.Count; i++) {
//			if (i < button.Length) {
//				StoreEntry entry = storeEntries [i];
//				button [i].SetText (entry.unit.unitName);
//				button [i].SetUnitTypeId (entry.unit.getUnitTypeId ());
//			}
//		}
//	}

	public void setStoreEntries(IList<StoreEntry> storeEntries) {
		this.storeEntries = storeEntries;
		for (int i = 0; i < storeEntries.Count; i++) {
			if (i < button.Length) {
				StoreEntry entry = storeEntries [i];
				button [i].SetText (entry.unit.unitName);
				button [i].SetUnitTypeId (entry.unit.getUnitTypeId ());
			}
		}
	}

	public void onClick(PurchaseButton button) {
		purchaseManager.Purchase (button.unitTypeId);
	}
}

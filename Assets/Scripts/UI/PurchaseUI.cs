using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PurchaseUI : MonoBehaviour {

	public PurchaseManager purchaseManager;

	public IList<StoreEntry> storeEntries;

	public PurchaseButton[] button;

	CursorManager cursorManager;

	void Start() {
		cursorManager = GameObject.Find ("GameManager").GetComponent<CursorManager> ();
		NotificationCenter.DefaultCenter.AddObserver (this, "SelectedAsteroid");
	}

	void OnDestroy() {
		NotificationCenter.DefaultCenter.RemoveObserver (this, "SelectedAsteroid");
	}

	public void SelectedAsteroid() {
		Store store = cursorManager.selectedAsteroid.GetComponent<Store> ();
		setStoreEntries (new List<StoreEntry>(store.storeEntries.Values));
	}

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

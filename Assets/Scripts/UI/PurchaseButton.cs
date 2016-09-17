using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PurchaseButton : MonoBehaviour {

	public Text label;
	public int unitTypeId;

	void Start() {
		label = GetComponentInChildren<Text>();
	}

	public void SetUnitTypeId(int id) {
		unitTypeId = id;
	}

	public void SetText(string text) {
		label.text = text + "\n some resource";
	}

}

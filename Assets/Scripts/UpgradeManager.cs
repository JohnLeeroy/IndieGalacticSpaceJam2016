using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UpgradeManager {

	private static UpgradeManager instance = new UpgradeManager();

	//<Upgrade Id, Upgrade Level> 
	Dictionary<int, int> upgradeTable;

	public UpgradeManager Instance {
		get { return instance; }
	}

	public UpgradeManager() {
		upgradeTable = new Dictionary<int, int> ();
		for (int i = Constants.CLICK_VALUE_UPGRADE_ID; i < Constants.UPGRADE_ID_END; i++) {
			upgradeTable[i] = 0;
		}
	}

	public float GetCost(int upgradeId, float baseCost) {
		int level = upgradeTable [upgradeId];
		return Mathf.Round (baseCost * Mathf.Pow(1.15f, level));
	}
}

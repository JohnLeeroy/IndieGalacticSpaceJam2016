using UnityEngine;
using System.Collections;

public class BuildUI : MonoBehaviour {

	public PurchaseManager purchaseManager;

	public void buyLaunchPad() {
		purchaseManager.Purchase (Constants.LAUNCH_PAD_TYPE_ID);
	}

	public void buySilo() {
		purchaseManager.Purchase (Constants.SILO_TYPE_ID);
	}

	public void buyRobotFacility() {
		purchaseManager.Purchase (Constants.ROBOT_FACTORY_TYPE_ID);
	}

	public void buyDrill() {
		purchaseManager.Purchase (Constants.DRILL_TYPE_ID);
	}

	public void buySolarCollector() {
		purchaseManager.Purchase (Constants.SOLAR_COLLECTOR_TYPE_ID);
	}
}

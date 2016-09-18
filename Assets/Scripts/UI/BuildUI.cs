using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuildUI : MonoBehaviour {

	public PurchaseManager purchaseManager;
	public CursorManager cursorManager;

	public Text drillTitleLabel;
	public Text launchPadTitleLabel;
	public Text robotFacilityTitleLabel;
	public Text siloTitleLabel;
	public Text solarCollectorTitleLabel;

	void Start() {
		StartCoroutine (CR_UpdateUI ());
	}

	IEnumerator CR_UpdateUI() {
		while (true) {
			Asteroid asteroid = cursorManager.selectedAsteroid;
			if (asteroid != null) {
				drillTitleLabel.text = "Drill (" + asteroid.GetDrillCount () + ")";
				launchPadTitleLabel.text = "Launch Pad (" + asteroid.GetLaunchPadCount () + ")";
				robotFacilityTitleLabel.text = "Robot Facility (" + asteroid.GetRobotFacilityCount () + ")";
				siloTitleLabel.text = "Silo (" + asteroid.GetSiloCount () + ")";
				solarCollectorTitleLabel.text = "Solar Collector (" + asteroid.GetSolarCollectorCount () + ")";
			}
			yield return new WaitForSeconds (.5f);
		}
	}

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

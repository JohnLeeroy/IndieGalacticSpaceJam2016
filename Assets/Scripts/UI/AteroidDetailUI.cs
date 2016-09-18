using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AteroidDetailUI : MonoBehaviour {

	public Text nameLabel;
	public Text areaLabel;
	public Text robotLabel;
	public Text powerLabel;
	public Text fuelLabel;
	public Text materialLabel;
	public Text sellableMatLabel;

	CursorManager cursorManager;

	// Use this for initialization
	void Start () {
		cursorManager = GameObject.Find ("GameManager").GetComponent<CursorManager> ();
		NotificationCenter.DefaultCenter.AddObserver (this, "SelectedAsteroid");
	}

	void SelectedAsteroid() {
		Asteroid asteroid = cursorManager.selectedAsteroid;
		nameLabel.text = asteroid.asteroidName;
		robotLabel.text = string.Format ("Robot: {0} / {0}", asteroid.robotUsed, asteroid.robotCount);   
		powerLabel.text = string.Format ("Power: {0} / {0}", asteroid.totalPowerConsumption, asteroid.totalPowerCapacity); 
		areaLabel.text = string.Format ("Area:   {0} / {0}", asteroid.buildingCapacityUsed, asteroid.buildingCapacity); 

		fuelLabel.text = string.Format ("Ore C : {0} / {0}", ShortenStr(asteroid.fuel), ShortenStr(asteroid.materialCapacity)); 
		materialLabel.text = string.Format ("Ore S: {0} / {0}", ShortenStr(asteroid.materials), ShortenStr(asteroid.materialCapacity)); 
		sellableMatLabel.text = string.Format ("Ore M: {0} / {0}", ShortenStr(asteroid.sellableMaterial), ShortenStr(asteroid.materialCapacity));
	}

	public string ShortenStr(float valueToConvert)
	{
		string converted;
		if (valueToConvert >= 1000000)
		{
			converted = (valueToConvert / 1000000f).ToString("f1") + " Mil";
		}
		else if (valueToConvert >= 1000)
		{
			converted = (valueToConvert / 1000f).ToString("f1") + " K";
		}
		else
		{
			//converted = "" + valueToConvert;
			converted = valueToConvert.ToString("f0");
		}
		return converted;
	}
}

using UnityEngine;
using System.Collections;

public class Drill : BaseBuilding {

	public float damage = 10;
	public float rateOfAttack = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		asteroid.Drill (damage * rateOfAttack * Time.deltaTime);
	}

	override public int GetCostType() {
		return Constants.COST_TYPE_MATERIALS;
	}

	override public int getUnitTypeId() {
		return Constants.DRILL_TYPE_ID;
	}
}

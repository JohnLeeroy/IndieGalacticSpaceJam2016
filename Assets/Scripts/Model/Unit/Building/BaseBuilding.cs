using UnityEngine;
using System.Collections;

public abstract class BaseBuilding : BaseUnit, IUnitCost {

	public Asteroid asteroid;  //my asteroid

	public void setAsteroid(Asteroid asteroid) {
		this.asteroid = asteroid;
	}

	public abstract void recalculateStats ();
	public abstract int getRobotsNeeded ();
	public abstract int getPowerNeeded ();
	public abstract int getAreaNeeded ();
	public abstract int getMaterialNeeded ();
}

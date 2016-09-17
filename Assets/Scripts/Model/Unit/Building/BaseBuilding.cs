using UnityEngine;
using System.Collections;

public abstract class BaseBuilding : BaseUnit {

	public Asteroid asteroid;  //my asteroid
	public float powerConsumption = 10;

	public void setAsteroid(Asteroid asteroid) {
		this.asteroid = asteroid;
	}

}

using UnityEngine;
using System.Collections;

public class BaseUnit : MonoBehaviour, ICost {

	public int buildCost;

	public string name;

	public string description;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public float GetCost() {
		return buildCost;
	}
}

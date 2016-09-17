using UnityEngine;
using System.Collections;

public class BaseUnit : MonoBehaviour, ICost {

	public int buildCost;

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

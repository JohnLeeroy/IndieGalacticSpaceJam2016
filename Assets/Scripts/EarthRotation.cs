using UnityEngine;
using System.Collections;

public class EarthRotation : MonoBehaviour {


	private float y; 
	public float speed = 10.0f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		y += Time.deltaTime * speed;
		transform.rotation = Quaternion.Euler(0,y,0);
	}
}

using UnityEngine;
using System.Collections;

public class EarthRotation : MonoBehaviour {

	public Transform probe;
	private float y; 
	public float speed = 10.0f; 
	public int clickerScore = 0;

	// Use this for initialization
	void Start () {
	
	}


	void OnMouseDown(){
		clickerScore++;
		Instantiate(probe, new Vector3(0, 0, 0), Quaternion.identity);
	}

	// Update is called once per frame
	void Update () {
		y += Time.deltaTime * speed;
		transform.rotation = Quaternion.Euler(0,y,0);
	}
}

using UnityEngine;
using System.Collections;

public class AsteroidRotation : MonoBehaviour {

	//public GameObject ship; 
	private float y; 
	private float z; 
	private float x; 

	public float xRotationSpeed = 10f;
	public float yRotationSpeed = 8f;
	public float zRotationSpeed = 4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		y -= Time.deltaTime * yRotationSpeed;
		x += Time.deltaTime * xRotationSpeed;
		z += Time.deltaTime * zRotationSpeed;

		transform.rotation = Quaternion.Euler(x,y,z);
//
//		if(Input.GetKeyDown("space")){
//			GameObject.FindGameObjectWithTag ("earth").GetComponent<EarthManager> ().BringShipsBack (ship, new Vector2 (transform.position.x, transform.position.y));
//		}
	}

//	void OnMouseDown(){
//		Debug.Log ("click");
//		GameObject.FindGameObjectWithTag ("earth").GetComponent<EarthManager> ().SpawnShips (ship, new Vector2 (transform.position.x, transform.position.y));
//
//	}
}

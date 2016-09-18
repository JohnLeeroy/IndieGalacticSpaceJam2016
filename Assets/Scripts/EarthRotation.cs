using UnityEngine;
using System.Collections;

public class EarthRotation : MonoBehaviour {

	public GameObject probe; //Remove This


	private float y; 
	public float earthRotationSpeed = 10.0f;  
	public int clickerScore = 0;
	private Vector2 myPos;

	void Start () {
		//Grabbing Earth's position so we can spawn the ships at the same location. 
		myPos = new Vector2(transform.position.x, transform.position.y);
	}

	void OnMouseDown(){
		
		clickerScore++;

	}

	// Update is called once per frame
	void Update () {
		y -= Time.deltaTime * earthRotationSpeed;
		transform.rotation = Quaternion.Euler(0,y,0);
	}

	public void SpawnShips(GameObject type, Vector2 locationOfAstroid){

		//Spawn the ship
		GameObject ship = (GameObject)Instantiate (type, myPos, Quaternion.identity);

		//Give the spawned ship the Vector2 location of the Astrod it's traveling to. 
		ship.GetComponent<MoveProbe>().moveToLocation = locationOfAstroid; 


	}
}

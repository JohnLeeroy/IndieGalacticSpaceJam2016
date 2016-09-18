using UnityEngine;
using System.Collections;

public class EarthManager : MonoBehaviour {

	private float y; 
	public float earthRotationSpeed = 10.0f;  
	private Vector2 myPos;

	void Start () {
		//Grabbing Earth's position so we can spawn the ships at the same location. 
		myPos = new Vector2(transform.position.x, transform.position.y);
	}
		
	// Update is called once per frame
	void Update () {
		
		y -= Time.deltaTime * earthRotationSpeed;
		transform.rotation = Quaternion.Euler(0,y,0);

	}
		
	void OnTriggerEnter(Collider other) {

		if(other.gameObject.tag == "freighter")
		{
			TransferCurrency(other.gameObject.GetComponent<FreighterController>().currency);
			Destroy(other.gameObject);
		}
	}
		

	public void SpawnShips(GameObject type, Vector2 locationOfAstroid){

		//Spawn the ship
		GameObject ship = (GameObject)Instantiate (type, myPos, Quaternion.identity);

		//Give the spawned ship the Vector2 location of the Astrod it's traveling to. 
		ship.GetComponent<MoveProbe>().moveToLocation = locationOfAstroid; 

	}

	public void BringShipsBack(GameObject type, Vector2 locationOfAstroid){

		//Spawn the ship
		GameObject freighter = (GameObject)Instantiate (type, locationOfAstroid, Quaternion.identity);

		//Give the spawned ship the Vector2 location of the Astrod it's traveling to. 
		freighter.GetComponent<FreighterController>().moveToLocation = myPos; 

	}

	public void TransferCurrency(float currency){
		
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ().AddToCashMoney(currency);
		Debug.Log (currency);

	}
}

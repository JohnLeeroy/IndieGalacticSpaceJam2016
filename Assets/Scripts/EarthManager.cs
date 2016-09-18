using UnityEngine;
using System.Collections;

public class EarthManager : MonoBehaviour {

	public GameObject probe; //Remove This


	private float y; 
	public float earthRotationSpeed = 10.0f;  
	public float clickerScore = 0;
	private Vector2 myPos;
	protected int streetTeam;
	protected int collegeTeam;
	protected int polictalTeam;

	protected bool steetTeamPurcahsed = false; 
	protected bool collegeTeamPurcahsed = false; 
	protected bool politicalTeamPurcahsed = false; 

	private float multiplier;

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

		clickerScore = clickerScore * FigureOutMultiplier();

	}

	public void SpawnShips(GameObject type, Vector2 locationOfAstroid){

		//Spawn the ship
		GameObject ship = (GameObject)Instantiate (type, myPos, Quaternion.identity);

		//Give the spawned ship the Vector2 location of the Astrod it's traveling to. 
		ship.GetComponent<MoveProbe>().moveToLocation = locationOfAstroid; 


	}

	public void BringShipsBack(GameObject type, Vector2 locationOfAstroid){

		//Spawn the ship
		GameObject ship = (GameObject)Instantiate (type, locationOfAstroid, Quaternion.identity);

		//Give the spawned ship the Vector2 location of the Astrod it's traveling to. 
		ship.GetComponent<MoveProbe>().moveToLocation = myPos; 


	}

	public void UpdateStreetTeam(){
		if(steetTeamPurcahsed){
			streetTeam++;
		}
		else{
			steetTeamPurcahsed = true; 
		}
	}

	public void UpdateCollegeTeam(){
		if(collegeTeamPurcahsed){
			collegeTeam++;
		}
		else{
			collegeTeamPurcahsed = true; 
		}
	}

	public void UpdatePolictalTeam(){
		if(politicalTeamPurcahsed){
			polictalTeam++;
		}
		else{
			politicalTeamPurcahsed = true; 
		}
	}

	private float FigureOutMultiplier(){
		

		if(steetTeamPurcahsed){
			multiplier = multiplier + 10;
		}

		if(collegeTeamPurcahsed){

			multiplier = multiplier + 50;
		}

		if(politicalTeamPurcahsed){
			multiplier = multiplier + 100; 
		}

		multiplier = multiplier + (streetTeam * 5);
		multiplier = multiplier + (collegeTeam * 25);
		multiplier = multiplier + (polictalTeam * 50);

		return multiplier;
	}

}

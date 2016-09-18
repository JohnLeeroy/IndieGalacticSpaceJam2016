using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float cashMoney;
	public float rate = 1;
	private float multiplier;

	protected int streetTeam;
	protected int collegeTeam;
	protected int polictalTeam;

	protected bool steetTeamPurcahsed = false; 
	protected bool collegeTeamPurcahsed = false; 
	protected bool politicalTeamPurcahsed = false; 


	void Start() {
		NotificationCenter.DefaultCenter.AddObserver (this, "ClickedEarth");
	}

	public void ClickedEarth() {
		incrementCashMoney ();
	}

	public void incrementCashMoney() {
		//TODO
		cashMoney += rate * Mathf.Max(1, FigureOutMultiplier());
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

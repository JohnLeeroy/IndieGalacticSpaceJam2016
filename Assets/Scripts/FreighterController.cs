using UnityEngine;
using System.Collections;

public class FreighterController : MonoBehaviour {

	public float currency; 
	public float speed = 5.0F;
	public Vector2 moveToLocation;
	public float currencyModifier = 1;

	// Use this for initialization
	void Start () {
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		audio.Play(44100);
	}
	
	// Update is called once per frame
	void Update () {

		// set rotation to move Location
		Quaternion rot = Quaternion.LookRotation(transform.position - new Vector3(moveToLocation.x, moveToLocation.y, transform.position.z) , Vector3.forward); 

		transform.rotation = rot; //rotates game object to correct position
		transform.eulerAngles = new Vector3(0,0,transform.eulerAngles.z); //remove X and y rotation

		transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), moveToLocation, speed * Time.deltaTime);
	}

	public void UpdateCurrency(float cur){
		currency += cur * currencyModifier; 
	}
}

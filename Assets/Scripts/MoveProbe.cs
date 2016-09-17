using UnityEngine;
using System.Collections;

public class MoveProbe : MonoBehaviour {

	public float speed = 1.0F;


	public Vector2 moveToLocation;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
			
		// set rotation to move Location
		Quaternion rot = Quaternion.LookRotation(transform.position - new Vector3(moveToLocation.x, moveToLocation.y, transform.position.z) , Vector3.forward); 

		transform.rotation = rot; //rotates game object to correct position
		Debug.Log(transform.rotation);
		transform.eulerAngles = new Vector3(0,0,transform.eulerAngles.z); //remove X and y rotation

		transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), moveToLocation, speed * Time.deltaTime);
	}
		
}

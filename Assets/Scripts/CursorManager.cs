using UnityEngine;
using System.Collections;

public class CursorManager : MonoBehaviour {

	//Ray
	Ray ray;
	RaycastHit hit;

	public Asteroid selectedAsteroid;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonUp(0))
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit, 500))
			{
				if(hit.transform.tag.Equals("asteroid"))
				{
					selectedAsteroid = hit.transform.GetComponent<Asteroid> ();
					NotificationCenter.DefaultCenter.PostNotification (this, "SelectedAsteroid");
				};
			}
		}
	}
}

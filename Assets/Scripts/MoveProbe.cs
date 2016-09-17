using UnityEngine;
using System.Collections;

public class MoveProbe : MonoBehaviour {
	public float target = 2070.0F;
	public float speed = 45.0F;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
			
		rb.velocity = new Vector2(5, 5);
	}

}

using UnityEngine;
using System.Collections;

public class DollarSign : MonoBehaviour {

	public float speed = 35.0f;


	void Start() {
		StartCoroutine(DestroyDollarSign());

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (new Vector2 (transform.position.x, transform.position.y), new Vector2(0, 1000), speed * Time.deltaTime);

	}

	IEnumerator DestroyDollarSign() {
		yield return new WaitForSeconds(.5f);
		Destroy(this.gameObject);
	}

}

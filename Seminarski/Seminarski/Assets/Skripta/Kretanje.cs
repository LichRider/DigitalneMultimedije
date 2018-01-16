using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kretanje : MonoBehaviour {


	public float speed = 0.09F;
	public float jump = 0.03F;

	private Rigidbody2D rb;
	private Vector3 kretanje = new Vector3 ();
	private bool zemlja;
	private bool pritisnuto;
	private Vector2 skok = new Vector2();



	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		pritisnuto = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			kretanje = new Vector3 (-1, 0, 0);
			kretanje *= speed;

			this.transform.Translate (kretanje);
		}
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			kretanje = new Vector3 (1, 0, 0);
			kretanje *= speed;

			this.transform.Translate (kretanje);
		}
		if (zemlja) 
		{
			if ((Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.Space)) && !pritisnuto) {
				skok = new Vector2 (1, 1);
				kretanje *= jump;

				rb.AddForce(Vector2.up * jump);
				pritisnuto = true;
			}
		}

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Zemlja") {
			zemlja = true;
			pritisnuto = false;


		}
	}
}
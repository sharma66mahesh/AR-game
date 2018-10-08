using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class cube : MonoBehaviour {
	public GameObject spawn;
	public GameObject plane;
	public Rigidbody rb;
	public float speed;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.localEulerAngles = new Vector3 (0, 0, 0);
		if(transform.position.y < (plane.transform.position.y - 10.0f))
		{
			transform.position = spawn.transform.position;
		}

	

		
	}
	void FixedUpdate(){
		
		if (plane.GetComponent<MeshRenderer>().enabled == true) {
			rb.useGravity = true;
		} else {
			rb.useGravity = false;
		}
			

	}

}

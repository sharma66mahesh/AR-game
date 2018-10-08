using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attract : MonoBehaviour {
	public GameObject player;
	public GameObject spawn;
	public float radius;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		if(Vector3.Distance(player.transform.position, transform.position) < radius)
			player.transform.position = Vector3.MoveTowards (player.transform.position, transform.position, 2.2f * Time.deltaTime);
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Player") {
			player.transform.position = spawn.transform.position;
		}
	}
}

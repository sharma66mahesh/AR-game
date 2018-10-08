using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3 (player.transform.position.x, player.transform.position.y + 0.4f, player.transform.position.z);
		//transform.eulerAngles = new Vector3 (0, player.transform.eulerAngles.y+90, 0);
		
	}
}

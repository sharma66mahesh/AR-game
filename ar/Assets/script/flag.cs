using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flag : MonoBehaviour {
	private float y;
	public GameObject player;
	// Use this for initialization
	void Start () {
		y = transform.position.y;
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.transform.position.x, y, player.transform.position.z);
	}
}

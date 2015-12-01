﻿using UnityEngine;
using System.Collections;

public class Jeff : MonoBehaviour {

	public Transform jeffSpawnPoints; // The parent of the spawn points
	public bool reSpawn = false;
	
	private Transform[] spawnPoints;
	private bool lastToggle = false;

	// Use this for initialization
	void Start () {
		spawnPoints = jeffSpawnPoints.GetComponentsInChildren<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (lastToggle != reSpawn) {
			Respawn ();
			reSpawn = false;
		} else {
			lastToggle = reSpawn;
		}
	}
	private void Respawn() {
		int i = Random.Range (1, spawnPoints.Length);
		transform.position = spawnPoints [i].transform.position;
	}
}

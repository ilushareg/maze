using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root_Init : MonoBehaviour {

	private LevelInfo level = new LevelInfo();
	// Use this for initialization
	void Start () {
		level.CreateObjects();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

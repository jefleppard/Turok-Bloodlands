using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class PointsMgr : MonoBehaviour {

public int startingPoints;
public Text displayPoints;

	// Use this for initialization
	void Start () {
		print ("Turok starts this scene with " +startingPoints+ " Points." );
		UpdateDisplay();
	}
	
	void AddPoints (int x) {
		print ("I'll add " +x+ " points to the player's balance.");
	}
	
	void CreatePool() {
		print ("I'll create a pool of points where Turok died.");
	}
	
	void UpdateDisplay () {
		displayPoints.text = "POINTS: " +startingPoints;
	}
}

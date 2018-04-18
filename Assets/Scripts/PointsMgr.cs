using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class PointsMgr : MonoBehaviour {

public int curPoints = 100;
public Text textPoints;
public GameObject Player;
public GameObject BloodPool;

	void Start () {
		print ("Turok starts this scene with " +curPoints+ " Points." );
		UpdateDisplay();
	}
	
	public void AddPoints (int x) {
		curPoints += x;
		print ("Added " +x+ " points to the player's balance. Now they have " +curPoints+"!");
		UpdateDisplay();
	}
	
	public void CreatePool() {
		print ("I'll create a pool of points where Turok died.");
		GameObject newPool = (GameObject) Instantiate(BloodPool, Player.transform.position, Quaternion.Euler(-90, 0, 0));
		PointsSource ps = newPool.GetComponent<PointsSource>();
		ps.SetPointValue(curPoints);
		LoseAll();
		UpdateDisplay();
	}
	
	void LoseAll (){
		curPoints = 0;
	}
	
	void UpdateDisplay () {
		textPoints.text = "POINTS: " +curPoints;
	}
}

using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class PointsSource : MonoBehaviour {

private GameObject pointsSys;
private PointsMgr pm;

public int PointValue = 10;
public TextMesh PointDisplay;

	void Start () {
		pointsSys = GameObject.Find("PointsSystem");
		pm = pointsSys.GetComponent<PointsMgr>();
		PointDisplay.text = "Points: " +PointValue;
	}
	
	public void SetPointValue (int x) {
		PointValue = x;
		PointDisplay.text = "Points: " +PointValue;
	}
	
	public void GrantPoints () {
		pm.AddPoints(PointValue);
	}
}
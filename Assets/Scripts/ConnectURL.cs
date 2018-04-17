using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectURL : MonoBehaviour {

    void Start() {
		print ("I'm just the dumb connect script. There's really nothing for me to do yet.");
    }
	
	public void OpenURL (){
		Application.OpenURL("http://unity3d.com/");
	}
}

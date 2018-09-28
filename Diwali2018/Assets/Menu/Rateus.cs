using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rateus : MonoBehaviour {

	public string url;

	public void rate(){
	
		Application.OpenURL (url);

	}
}

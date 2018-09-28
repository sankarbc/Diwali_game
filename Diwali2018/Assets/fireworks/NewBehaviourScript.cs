using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public ParticleSystem[] ga;
	public Sound sn;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			int i=0;
			i=Random.Range(0,ga.Length);
			ga[i].Emit(1);
			call ();
		}
	}
	public void call()
	{
		sn.play ();
	}
}

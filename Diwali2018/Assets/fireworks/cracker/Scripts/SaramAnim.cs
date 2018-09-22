using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaramAnim : MonoBehaviour {

Animator animator;
	// Use this for initialization
	void Start () {
					    animator = this.GetComponent<Animator>();

		        StartCoroutine(boom());

	}
	
	IEnumerator boom()
	{

		yield return new WaitForSeconds (5f);
										    animator.SetInteger("burst",1);
        
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

public AudioClip audio;
public float delay;

	// Use this for initialization
	void Start () {
		
		GetComponent<AudioSource>().clip=audio;
		
	}
	
	
	
	public void play(){
		
        StartCoroutine(boom());

	}
	
	 IEnumerator boom()
    {

        yield return new WaitForSeconds(delay);
						GetComponent<AudioSource>().PlayOneShot(audio);
    
    }
}

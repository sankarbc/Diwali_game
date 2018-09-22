using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saram : MonoBehaviour {

public GameObject cracker_duplicate;
public Rocket player;
public Sound sound;
public static bool isstop;

	
		    void OnMouseDown()
    {
		
		isstop=Rocket.stop;
		if(isstop==true){
					player.StartLerping();

        GameObject cracker_duplicate1 = Instantiate(cracker_duplicate, new Vector3(1.33f,-2f,-3f), transform.rotation) as GameObject;
						sound.play();

		}
		}
			
}

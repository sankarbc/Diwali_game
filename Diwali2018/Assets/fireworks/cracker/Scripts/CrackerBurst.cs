using UnityEngine;
using System.Collections;

public class CrackerBurst : MonoBehaviour {

   public ParticleSystem burst_particle;
    public float delay_time;
    public GameObject cracker_duplicate;
    public float x, y, z;
public Rocket player;
public static bool isstop;
   public Sound sound,thiri_sound;

	
	
    void OnMouseDown()
    {
		isstop=Rocket.stop;
		if(isstop==true){
			player.StartLerping();
        GameObject cracker_duplicate1 = Instantiate(cracker_duplicate, new Vector3(x,y,z), transform.rotation) as GameObject;
        StartCoroutine(boom());
		        StartCoroutine(boom1());

		}

    }

    IEnumerator boom()
    {

        yield return new WaitForSeconds(delay_time);
				sound.play();
        burst_particle.Play();
        
    }
	IEnumerator boom1()
    {

        yield return new WaitForSeconds(delay_time-3.5f);
		thiri_sound.play();
        
    }
}

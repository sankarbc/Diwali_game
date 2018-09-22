using UnityEngine;
using System.Collections;

public class RocketCracker : MonoBehaviour {

   public ParticleSystem burst_particle,burst_particle1;
    public float delay_time;
    public GameObject cracker_duplicate;
    public float x, y, z;
public Rocket player;
public static bool isstop;
   public Sound sound,rocket_sound;


	
	
    void OnMouseDown()
    {
		isstop=Rocket.stop;
		if(isstop==true){
			player.StartLerping();
        GameObject cracker_duplicate1 = Instantiate(cracker_duplicate, new Vector3(x,y,z), transform.rotation) as GameObject;
        StartCoroutine(boom());
		        StartCoroutine(boom1());
								sound.play();


		}

    }

    IEnumerator boom()
    {

        yield return new WaitForSeconds(delay_time);
        burst_particle.Play();
										rocket_sound.play();

        
    }
	 IEnumerator boom1()
    {

        yield return new WaitForSeconds(delay_time-3f);
        burst_particle1.Play();

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {

    public Canvas show_scroll;
    public Canvas show_show;
    public GameObject nilaa;
    public ParticleSystem burst_particle;
    
    public ParticleSystem burst_particle1;
    public float delay_time;
    public float delay_thiri;
    public bool isdestroy;
    public Sound sound, thiri_sound;
    public static int click;
    int play_fire;

   

    void Start()
    {
        
        show_scroll.enabled = true;
        show_show.enabled = false;
        nilaa.SetActive(false);
        click = 0;
        play_fire = 0;
        
    }
    
    public void show()
    {
       
        if (click == 0)
        {
            
            click = 1;


            if (nilaa.name == "rocket_1")
            {
                show_show.enabled = true;
                nilaa.SetActive(true);
                StartCoroutine(blast());

            }

            if (nilaa.name == "rocket_2")
            {
                show_show.enabled = true;
                nilaa.SetActive(true);
                StartCoroutine(blast());

            }
            if (nilaa.name == "rocket_3")
            {
                show_show.enabled = true;
                nilaa.SetActive(true);
                StartCoroutine(blast());

            }
            if (nilaa.name == "rocket_4")
            {
                show_show.enabled = true;
                nilaa.SetActive(true);
                StartCoroutine(blast());

            }


        }

    }
    IEnumerator blast()
    {
        
        burst_particle1.Play();
        thiri_sound.play();
        yield return new WaitForSeconds(delay_thiri);
        

        sound.play();
     
        StartCoroutine(fire1());

    }
    IEnumerator fire1()
    {

        yield return new WaitForSeconds(delay_time);
        
        burst_particle.Play();
        if (isdestroy)
        {

            nilaa.SetActive(false);
            

            StartCoroutine(fire2());

        }
    }
    IEnumerator fire2()
    {

        yield return new WaitForSeconds(1);
        //burst_particle.Stop();
    
        click = 0;
    }
}

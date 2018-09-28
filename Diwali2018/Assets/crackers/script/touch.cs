using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    public Canvas show_scroll;
    public Canvas show_show;
    public GameObject nilaa;
    public ParticleSystem burst_particle;
   
    public float delay_time;
 
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
        print("nil;0");
        if (click == 0)
        {
            print("nil;1");
            click = 1;


            if (nilaa.name == "Nila")
            {
                show_show.enabled = true;
                nilaa.SetActive(true);
                StartCoroutine(blast());

            }
            else if (nilaa.name == "chakaram")
            {

                show_show.enabled = true;
                nilaa.SetActive(true);
                StartCoroutine(blast());

            }

            else if (nilaa.name == "bomb_blue")
            {

                show_show.enabled = true;
                nilaa.SetActive(true);
                StartCoroutine(blast());
            }
            else if (nilaa.name == "bomb_red")
            {

                show_show.enabled = true;
                nilaa.SetActive(true);
                StartCoroutine(blast());
            }
            else if (nilaa.name == "nila_red")
            {

                show_show.enabled = true;
                nilaa.SetActive(true);
                StartCoroutine(blast());
            }
            else if (nilaa.name == "bomb_rose")
            {

                show_show.enabled = true;
                nilaa.SetActive(true);
                StartCoroutine(blast());
            }
            else if (nilaa.name == "bomb_green")
            {

                show_show.enabled = true;
                nilaa.SetActive(true);
                StartCoroutine(blast());
            }
            else if (nilaa.name == "vedi red")
            {

                show_show.enabled = true;
                nilaa.SetActive(true);
                StartCoroutine(blast());
            }
            else if (nilaa.name == "bomb_star")
            {

                show_show.enabled = true;
                nilaa.SetActive(true);
                StartCoroutine(blast());
            
            }

        }

    }
    IEnumerator blast()
    {

        thiri_sound.play();
        yield return new WaitForSeconds(1f);
      
       
        sound.play();
        burst_particle.Play();
        StartCoroutine(fire1());
       
    }
    IEnumerator fire1()
    {

        yield return new WaitForSeconds(delay_time);
       
        if (isdestroy)
        {

            nilaa.SetActive(false);

           
            StartCoroutine(fire2());

        }
    }
    IEnumerator fire2()
    {
       
        yield return new WaitForSeconds(2);
        burst_particle.Stop();
        click = 0;
    }
}
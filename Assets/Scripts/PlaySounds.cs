using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    public AudioSource confirm1;
    public AudioSource confirm2;
    public AudioSource confirm3;
    public AudioSource click1;
    public AudioSource click2;
    public AudioSource click3;

    public AudioSource soundfx;
    public AudioClip hoverSound;
    
    public void HoverSound()
    {
        soundfx.PlayOneShot(hoverSound);
    }
    //public AudioSource scifibuttons;
    public void playCF1()
    {
        confirm1.Play();
        //Debug.Log("Played 1");
    }
    public void playCF2()
    {
        confirm2.Play();
        //Debug.Log("Played 2");
    }
    public void playCF3()
    {
        confirm3.Play();
        //Debug.Log("Played 3");
    }
    public void playButton1()
    {
        click1.Play();
        //Debug.Log("Played 4");
    }
    public void playButton2()
    {
        click2.Play();
        //Debug.Log("Played 5");
    }
    public void playButton3()
    {
        click3.Play();
        //Debug.Log("Played 6");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource aSrc;

    public AudioClip shooting;
    public AudioClip shipDeath;
    public AudioClip asteroidDeath;


    public void PlayShooting()
    {
        aSrc.PlayOneShot(shooting);
    }


    public void PlayDeath()
    {
        aSrc.PlayOneShot(shipDeath);
    }

    public void PlayAsteroid()
    {
        aSrc.PlayOneShot(asteroidDeath);
    }

}

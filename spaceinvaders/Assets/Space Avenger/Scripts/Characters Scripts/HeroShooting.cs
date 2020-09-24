using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

// © Glitch Squirrel Design 2017
// All right reserved.

public class HeroShooting : MonoBehaviour
{

    [Header("Weapon setup")]
    public GameObject projectile;
    public Transform weapon;
    public float projectileSpeed;

    [SerializeField]
    private float autofireRate = 0.5f;
    [SerializeField]
    private float nextFire = 0.0f;

    [Header("Sounds")]
    public AudioClip projectileSound;
    public AudioSource source;

    public void Update()
    {
		/*if (CnInputManager.GetButtonDown("Fire"))
        {
            Shoot();
        }
        */

        if (Time.time > nextFire)
        {
            nextFire = Time.time + autofireRate;
            Shoot();
        }
    }

    public void Shoot()
    {
		GameObject newProjectile = Instantiate(projectile, weapon.transform);
		Destroy(newProjectile, 20);
        source.PlayOneShot(projectileSound, Random.Range(0.1f, 0.3f));
    }
}

// © Glitch Squirrel Design 2017
// All right reserved.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CnControls;

// © Glitch Squirrel Design 2017
// All right reserved.

public class HeroMovement : MonoBehaviour {

    [Header("Hero Reference")]
    public Rigidbody2D hero;

    [Header("Movement")]
    public float heroSpeedFactor;
    public float heroSpeed;
    public float heroMaxSpeed;

    [Header("Sounds")]
    public AudioClip engineSound;
    private AudioSource source;

    public Slider slider;
    private float sliderValue;

    private void FixedUpdate()
    {
        sliderValue = slider.value;
        Vector3 temp = transform.position;
        temp.x = sliderValue;
        transform.localPosition = temp;

        if (hero.velocity.x < heroMaxSpeed)
        {
			float h = CnInputManager.GetAxis("Horizontal");
            hero.AddForce(Vector2.right * heroSpeed * heroSpeedFactor * h, ForceMode2D.Force);
        }
    }
}

// © Glitch Squirrel Design 2017
// All right reserved.

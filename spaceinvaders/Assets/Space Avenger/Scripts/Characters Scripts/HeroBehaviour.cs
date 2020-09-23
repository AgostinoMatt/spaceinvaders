using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// © Glitch Squirrel Design 2017
// All right reserved.

public class HeroBehaviour : MonoBehaviour {

	[Header("Stats")]
    public float heroHealth;

	[Header("HUD")]
	public Slider heroHealthSlider;

	[Header("FX")]
	public GameObject deathFX;

    private UIBehaviour ui;

	private void Awake()
	{
		ui = FindObjectOfType<UIBehaviour>();
	}

	private void Start()
	{
        heroHealthSlider.maxValue = heroHealth;
	}

	private void Update()
	{
        heroHealthSlider.value = heroHealth;
	}

	private void FX(Collider2D collision)
	{
        GameObject newDeathFX = Instantiate(deathFX, collision.transform);
		newDeathFX.transform.parent = null;
		Destroy(newDeathFX, 1);
	}

    public void ReceiveDamage(Collider2D collision)
    {
        if (heroHealth > 1)
        {
            heroHealth -= 1;
            FX(collision);

        }
        else
        {
            ui.GameOver();
            FX(collision);
            Destroy(gameObject);
        }
    }
}

// © Glitch Squirrel Design 2017
// All right reserved.

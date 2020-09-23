using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// © Glitch Squirrel Design 2017
// All right reserved.

public class EnemyBehaviour : MonoBehaviour {

	[Header("Stats")]
    public float enemyHealth;

	[Header("Weapon setup")]
	public GameObject bullet;
	public Transform weapon;
    public float shootingDelay;

	[Header("HUD")]
    public Slider enemyHealthSlider;

    [Header("FX")]
    public GameObject deathFX;

	[Header("Sounds")]
	public AudioClip bulletSound;
    private AudioSource source;

    private UIBehaviour ui;

    private void Awake()
    {
        ui = FindObjectOfType<UIBehaviour>();
        source = GameObject.FindWithTag("Sound").GetComponent<AudioSource>();
    }

    private void Start()
    {
        enemyHealth = Random.Range(enemyHealth * 0.5f, enemyHealth * 1.5f);
        enemyHealthSlider.maxValue = enemyHealth;

        InvokeRepeating("Shoot",shootingDelay, Random.Range(shootingDelay * 0.75f, shootingDelay * 1.25f));
    }

    private void Update()
    {
        enemyHealthSlider.value = enemyHealth;
    }

    public void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, weapon.transform.position, new Quaternion(0,0,180,0));
        source.PlayOneShot(bulletSound, Random.Range(0.1f, 0.3f));
    }

	public void ReceiveDamage()
	{
		if (enemyHealth > 1)
		{
			enemyHealth -= 1;
            ui.IncomeScore(10);
		}
		else
		{
			Destroy(gameObject);
			FindObjectOfType<Waves>().onlineEnemies--;
            ui.IncomeScore(1000);
		}
	}
}

// © Glitch Squirrel Design 2017
// All right reserved.
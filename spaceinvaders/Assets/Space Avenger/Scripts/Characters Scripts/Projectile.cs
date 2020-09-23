using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// © Glitch Squirrel Design 2017
// All right reserved.

public class Projectile : MonoBehaviour {

	[Header("Projectile setup")]
    public float projectileSpeed;
    public GameObject destroyFX;

	private AudioSource source;
	public AudioClip[] clip;

	private void Awake()
	{
		source = GameObject.FindWithTag("Sound").GetComponent<AudioSource>();
	}

	void Start () 
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * projectileSpeed, ForceMode2D.Impulse);
        Destroy(gameObject,20);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{

		if (collision.gameObject.tag == "Enemy")
		{
            FX();
            collision.GetComponent<EnemyBehaviour>().ReceiveDamage();
            Destroy(gameObject);
		}

		if (collision.gameObject.tag == "Bullet")
		{
            FX();
            Destroy(gameObject);
		}
	}

	private void FX()
	{
		GameObject newDeathFX = Instantiate(destroyFX, gameObject.transform);
        source.PlayOneShot(clip[Random.Range(0, clip.Length)], Random.Range(0.4f, 0.6f));
		newDeathFX.transform.parent = null;
		Destroy(newDeathFX, 1);
	}
}

// © Glitch Squirrel Design 2017
// All right reserved.
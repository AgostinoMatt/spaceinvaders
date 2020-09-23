using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// © Glitch Squirrel Design 2017
// All right reserved.

public class Bullet : MonoBehaviour {

	[Header("Bullet setup")]
    public float bulletSpeed;
	public GameObject destroyFX;

    private AudioSource source;
    public AudioClip clip;

    private void Awake()
    {
        source = GameObject.FindWithTag("Sound").GetComponent<AudioSource>();
    }

    void Start()
	{
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * -bulletSpeed, ForceMode2D.Impulse);
		Destroy(gameObject, 20);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{

		if (collision.gameObject.tag == "Player")
		{
            FX();
            collision.GetComponent<HeroBehaviour>().ReceiveDamage(collision);
            Destroy(gameObject);
		}

		if (collision.gameObject.tag == "Projectile")
		{
			FX();
			Destroy(gameObject);
		}
	}

	private void FX()
	{
		GameObject newDeathFX = Instantiate(destroyFX, gameObject.transform);
		newDeathFX.transform.parent = null;
        source.PlayOneShot(clip, Random.Range(0.4f, 0.5f));
		Destroy(newDeathFX, 1);
	}
}

// © Glitch Squirrel Design 2017
// All right reserved.


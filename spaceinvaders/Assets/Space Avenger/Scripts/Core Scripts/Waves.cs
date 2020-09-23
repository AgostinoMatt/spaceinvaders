using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// © Glitch Squirrel Design 2017
// All right reserved.

public class Waves : MonoBehaviour {

    [Header("Time")]
    public float wavesDelay;
    private float time;
    public Text count;

    [Header("Spawners")]
    public Transform[] spawners;

    [Header("Enemies")]
    public GameObject[] enemy;
    public int onlineEnemies;

    private bool waveOnline;

    private void Start()
    {
        count.color = new Color(1, 1, 1, 0);
    }

    private void Update()
    {
        if (onlineEnemies <= 0 && waveOnline == false)
        {
            StartCoroutine(SpawnWave());
        }
    }

    public IEnumerator SpawnWave()
    {
        waveOnline = true;

        yield return new WaitForSeconds(1);
        count.color = new Color(1, 1, 1, 0.5f);
        count.text = "NEXT WAVE IN ... 3";
        yield return new WaitForSeconds(1);
        count.text = "NEXT WAVE IN ... 2";
		yield return new WaitForSeconds(1);
        count.text = "NEXT WAVE IN ... 1";
		yield return new WaitForSeconds(1);
		count.text = "FIGHT!";
		yield return new WaitForSeconds(1);
        count.color = new Color(1, 1, 1, 0);

        foreach(Transform spawner in spawners)
        {
            onlineEnemies++;
            yield return new WaitForSeconds(Random.Range(0.1f, 0.3f));
            GameObject newEnemyT0 = Instantiate(enemy[Random.Range(0, enemy.Length)], spawner.transform);
        }

        waveOnline = false;
    }
}

// © Glitch Squirrel Design 2017
// All right reserved.

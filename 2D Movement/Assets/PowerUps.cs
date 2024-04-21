using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public GameObject[] powerups;

    void Start()
    {
        StartCoroutine(SpawnPowerup());
    }

    public IEnumerator SpawnPowerup()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            int randomIndex = Random.Range(0, powerups.Length);
            GameObject newPowerup = Instantiate(powerups[randomIndex], new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0), Quaternion.identity);
            StartCoroutine(DestroyPowerup(newPowerup));
        }
    }

    IEnumerator DestroyPowerup(GameObject powerup)
    {
        yield return new WaitForSeconds(5);
        Destroy(powerup);
    }
}

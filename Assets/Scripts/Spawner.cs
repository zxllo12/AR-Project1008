using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    float spawnInterval = 2f;
    float timeSinceLastSpawn = 0f;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            GameObject newPipe = Instantiate(pipePrefab, transform);
            newPipe.GetComponent<RectTransform>().anchoredPosition = new Vector2(Screen.width, Random.Range(-100f, 100f));
            timeSinceLastSpawn = 0f;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawn : MonoBehaviour {
    public GameObject[] spawnPoints;
    public GameObject[] fruits;
    public int fruitPerBatch;
    public int spawnDiff;

    void Start () {
		for(int i = 0; i < spawnPoints.Length; i++) {
            spawnFruit(fruits, i);
        }
	}

    public void spawnFruit(GameObject[] fruits, int spawnPoint) {
        int fruitGroup = Random.Range(0, fruits.Length);
        for(int i = 0; i < fruitPerBatch; i++)
        {
            Transform newPoint = spawnPoints[spawnPoint].transform;
            newPoint.position += new Vector3(Random.Range(-spawnDiff, spawnDiff), 0, Random.Range(-spawnDiff, spawnDiff));
            Instantiate(fruits[fruitGroup], spawnPoints[spawnPoint].transform);
        }
    }

    internal void isActiveAndEnabled(bool v)
    {
        throw new NotImplementedException();
    }
}

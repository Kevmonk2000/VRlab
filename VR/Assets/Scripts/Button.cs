using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button : MonoBehaviour
{
    float timeLeft;
    public GameObject countText;
    bool startHit = false;

    private void Start()
    {
        timeLeft = 120f;
    }

    private void Update()
    {
        if(timeLeft < 0)
        {
            startHit = false;
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Fruit");

            for(int i = 0; i < gameObjects.Length; i++)
            {
                Destroy(gameObjects[i]);
            }
        }
        
        if (startHit == true)
        {
            timeLeft -= Time.deltaTime;
            countText.GetComponent<TextMeshProUGUI>().SetText("Time Left: " + Mathf.Floor(timeLeft).ToString());
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            startHit = true;
            timeLeft = 120f;
            this.GetComponent<FruitSpawn>().isActiveAndEnabled(true);
        }
    }
}
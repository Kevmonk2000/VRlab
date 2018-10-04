using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button : MonoBehaviour
{
    float timeLeft;
    public GameObject countText;
    public GameObject scoreText;
    bool startHit = false;
    float startTime = 10f;

    private void Start()
    {
        timeLeft = startTime;
    }

    private void Update()
    {
        if(timeLeft < 0)
        {
            startHit = false;
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Fruit");
            countText.GetComponent<TextMeshProUGUI>().SetText("Time Left: " + 0);

            for (int i = 0; i < gameObjects.Length; i++)
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
            scoreText.GetComponent<TextMeshProUGUI>().SetText("Score: " + 0)
            startHit = true;
            timeLeft = startTime;
            this.GetComponent<FruitSpawn>().isActiveAndEnabled(true);;
        }
    }
}
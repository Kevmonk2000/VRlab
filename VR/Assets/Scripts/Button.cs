using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    float timeLeft = 60f;
    public TextMesh countText;

    private void Start()
    {
        //timeLeft -= Time.deltaTime;

        //countText.text = "Time Left: " + timeLeft.ToString();
    }
    private void Update()
    {
        //timeLeft -= Time.deltaTime;
        //countText.text = "Time Left: " + timeLeft.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.GetComponent<FruitSpawn>().isActiveAndEnabled(true);
            timeLeft -= Time.deltaTime;

            countText.text = "Time Left: " + timeLeft.ToString();

        }
    }


}
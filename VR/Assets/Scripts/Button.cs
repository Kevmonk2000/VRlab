using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button : MonoBehaviour
{
    float timeLeft = 120f;
    public GameObject countText;
    bool lol = false;

    private void Start()
    {
  
    }
    private void Update()
    {
        
        if (lol == true)
        {
            timeLeft -= Time.deltaTime;
            countText.GetComponent<TextMeshProUGUI>().SetText("Time Left: " + Mathf.Floor(timeLeft).ToString());
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lol = true;

            this.GetComponent<FruitSpawn>().isActiveAndEnabled(true);

        }
    }
    

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    float timeLeft = 120f;
    public TextMesh countText;
    bool lol = false;

    private void Start()
    {
        //timeLeft -= Time.deltaTime;

        //countText.text = "Time Left: " + timeLeft.ToString();
    }
    private void Update()
    {
        
        if (lol == true)
        {
            timeLeft -= Time.deltaTime;
            countText.text = "Time Left: " +Mathf.Floor(timeLeft).ToString();
        }
        //countText.text = "Time Left: " + timeLeft.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (lol == false)
            {
                this.GetComponent<FruitSpawn>().isActiveAndEnabled(true);
            }


            lol = true;
            //timeLeft = 120f;



        }
    }
    

}
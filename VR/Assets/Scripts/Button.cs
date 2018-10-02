using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    float timeLeft = 60.0f;
    public Text timerLabel;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            this.GetComponent<FruitSpawn>().isActiveAndEnabled(true);
            timeLeft -= Time.deltaTime;
            
            
        }
    }


}
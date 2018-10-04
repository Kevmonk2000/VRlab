using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreModifier : MonoBehaviour {
    public GameObject scoreText;
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Fruit")
        {
            score++;
            scoreText.GetComponent<TextMeshProUGUI>().SetText("Score: " + score);
            other.gameObject.tag = "Untagged";
            other.gameObject.layer = 0;
        }
    }
}

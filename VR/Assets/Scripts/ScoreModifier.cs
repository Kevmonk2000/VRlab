using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreModifier : MonoBehaviour {
    public TextMesh scoreText;
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Fruit")
        {
            score++;
            scoreText.text = "Score: " + score;
            other.gameObject.tag = "Untagged";
            other.gameObject.layer = 0;
        }
    }
}

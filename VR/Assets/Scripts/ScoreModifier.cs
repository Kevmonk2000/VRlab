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
            Destroy(other.gameObject);
        }
    }
}

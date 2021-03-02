using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    public int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + scoreValue;
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + scoreValue;
    }


    public void Update()
    {
        scoreText.text = "Score: " + scoreValue;
    }
}  
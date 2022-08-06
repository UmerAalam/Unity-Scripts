using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScoreByTime : MonoBehaviour
{
    public Text scoreText;
    public int score;

    void Start()
    {
        score = 0;
        scoreText.text = "0";
        
    }
    void Update()
    {
        StartCoroutine("AddScoreTime");
    }

    IEnumerator AddScoreTime()
    {
        yield return new WaitForSeconds(0.5f);
        score++;
        scoreText.text = "" + score;
    }
}

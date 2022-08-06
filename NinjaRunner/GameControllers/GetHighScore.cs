using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetHighScore : HighScore
{
    [SerializeField] Text highScorePanel;
    void Update()
    {
        highScorePanel.text = PlayerPrefs.GetInt("HighScore",highScore).ToString();
    }
}

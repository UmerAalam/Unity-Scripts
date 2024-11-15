﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    [SerializeField] int difficulty;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }
    void Update()
    {
        
    }
    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " Was Clicked");
        gameManager.StartGame(difficulty);
    }
}

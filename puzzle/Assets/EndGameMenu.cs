using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGameMenu : MonoBehaviour
{
    public static EndGameMenu Instance { get; private set; }
    private void Awake() 
    {

        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        {
            Instance = this; 
        }
    }
    
    [SerializeField] private TMP_Text score;
    [SerializeField] private TMP_Text move;
    [SerializeField] private TMP_Text name;

    private void Update()
    {
        score.text = GameManager.Instance.score.ToString();
        move.text = GameManager.Instance.move.ToString();
        name.text = GameManager.Instance.playerName;
    }

    public void RestartGame()
    {
        MenuManager.Instance.RestartGame();
    }
}

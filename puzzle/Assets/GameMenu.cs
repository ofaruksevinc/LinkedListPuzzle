using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public static GameMenu Instance { get; private set; }
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

    [SerializeField] public TMP_Text name;
    [SerializeField] public TMP_Text move;
    [SerializeField] public TMP_Text score;

    private void Update()
    {
        move.text = GameManager.Instance.move.ToString();
        score.text = GameManager.Instance.score.ToString();
        name.text = GameManager.Instance.playerName;
    }
}

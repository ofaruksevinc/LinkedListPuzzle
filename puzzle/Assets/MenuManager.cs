using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    
    public static MenuManager Instance { get; private set; }
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
    
    
    [SerializeField] private StartMenu _startMenu;
    [SerializeField] private GameMenu _gameMenu;
    [SerializeField] private EndGameMenu _endGameMenu;

    public void StartGame()
    {
        GameManager.Instance.playerName = StartMenu.Instance.name;
        _startMenu.gameObject.SetActive(false);
        _gameMenu.gameObject.SetActive(true);
        GameMenu.Instance.name.text = GameManager.Instance.name;
    }

    public void EndGame()
    {
        _gameMenu.gameObject.SetActive(false);
        _endGameMenu.gameObject.SetActive(true);
        GameManager.Instance.WriteFile();
    }

    public void RestartGame()
    {
        Application.LoadLevel("GameScene");
    }
}

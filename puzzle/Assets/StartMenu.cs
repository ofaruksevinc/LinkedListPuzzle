using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public static StartMenu Instance { get; private set; }
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

    [SerializeField] private TMP_InputField nameInput;
    public new string name;

    public void SetName()
    {
        name = nameInput.text;
        MenuManager.Instance.StartGame();
    }
}

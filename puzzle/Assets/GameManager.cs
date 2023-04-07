using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
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

    private void Start()
    {
        string dosyaAdi = "enyuksekskor.txt";
        string dosyaYolu = Path.Combine(Application.dataPath, dosyaAdi);

        if (!File.Exists(dosyaYolu))
        {
            using (StreamWriter sw = File.CreateText(dosyaYolu))
            {
                sw.WriteLine("Ad,Hamle,Puan");
            }
            Debug.Log(dosyaAdi + " dosyasi olusturuldu. Dosya yolu: " + dosyaYolu);
        }
        else
        {
            Debug.Log(dosyaAdi + " dosyasi zaten var. Dosya yolu: " + dosyaYolu);
        }
    }

    public void WriteFile()
    {
        string dosyaAdi = "enyuksekskor.txt";
        string dosyaYolu = Path.Combine(Application.dataPath, dosyaAdi);
        
        using (StreamWriter sw = File.AppendText(dosyaYolu))
        {
            sw.WriteLine(playerName + "," + move + "," + score);
        }
    }

    public void ReadScores()
    {
        string dosyaAdi = "enyuksekskor.txt";
        string dosyaYolu = Path.Combine(Application.dataPath, dosyaAdi);
        
        List<string> kayitlar = new List<string>();

        using (StreamReader sr = new StreamReader(dosyaYolu)) 
        {
            string satir;
            while ((satir = sr.ReadLine()) != null)
            {
                string[] sutun = satir.Split(',');
                if (sutun[2] != "Puan")
                {
                    string kayit = sutun[0] + "," + sutun[2];
                    kayitlar.Add(kayit);
                }
            }
        }

        string scores = "";
        foreach (var i in kayitlar)
        {
            scores = scores + i + "\n";
        }

        GameMenu.Instance.highScores.text = scores;
    }

    public string playerName;
    public int score = 0;
    public int move = 0;
    public int sameNode = 0;
}

using System.IO;
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

    public string playerName;
    public int score = 0;
    public int move = 0;
    public int sameNode = 0;
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileManager : MonoBehaviour
{
    public static FileManager Instance { get; private set; }
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
    
    public GameObject image;
    public GameObject[] newImage;


    public LinkedList<Sprite> main = new LinkedList<Sprite>();
    public LinkedList<Sprite> mixed = new LinkedList<Sprite>();
    

    public GameObject first;
    public GameObject second;

    public void Slice()
    {
        main.Clear();

        Texture2D texture = image.GetComponent<Image>().sprite.texture;
        int index = 0;

        for (int j = 3; j >= 0; j--)
        {
            for (int i = 0; i < 4; i++)
            {
                var rect = new Rect(i*texture.width / 4,j*texture.height / 4, texture.width / 4, texture.height / 4);
                Sprite sprite = Sprite.Create(texture, rect, Vector2.one * 0.5f);
                
                // newImage[index].GetComponent<Image>().sprite = sprite;

                main.AddLast(sprite);

                // index++;
            }
        }

        UpdateImage(main.First);
    }

    public void Swap()
    {
        LinkedListNode<Sprite> firstClickNode = mixed.Find(first.GetComponent<Image>().sprite);
        LinkedListNode<Sprite> secondClickNode = mixed.Find(second.GetComponent<Image>().sprite);
        
        if (firstClickNode == secondClickNode)
            return;
        
        Sprite tempSprite = firstClickNode.Value;
        firstClickNode.Value = secondClickNode.Value;
        secondClickNode.Value = tempSprite;
        
        UpdateImage(mixed.First);
        
        first = second = null;

        GameManager.Instance.move++;
        
        Debug.Log("Score : " + SameNodeCount());
    }

    public void Shuffle()
    {
        mixed.Clear();

        LinkedList<Sprite> copyLinkedList = new LinkedList<Sprite>(main);
        
        for (int i = 0; i < 16; i++)
        {
            LinkedListNode<Sprite> copyNode = copyLinkedList.First;
            int index = UnityEngine.Random.Range(0, copyLinkedList.Count);
            
            for (int j = 0; j < index; j++)
            {
                copyNode = copyNode.Next;
            }
            copyLinkedList.Remove(copyNode);
            mixed.AddLast(copyNode);
        }

        UpdateImage(mixed.First);
        
        Debug.Log(SameNodeCount());
        
    }

    public void UpdateImage(LinkedListNode<Sprite> node)
    {
        foreach (var i in newImage)
        {
            i.GetComponent<Image>().sprite = node.Value;
            node = node.Next;
        }
    }

    public int SameNodeCount()
    {
        int buttonIndex = 0;
        
        LinkedListNode<Sprite> mixedNode = mixed.First;
        LinkedListNode<Sprite> mainNode = main.First;
        
        int count = 0;
        
        while (mixedNode != null)
        {
            if (mixedNode.Value == mainNode.Value)
            {
                count++;
                newImage[buttonIndex].GetComponent<Button>().interactable = false;
            }
            mixedNode = mixedNode.Next;
            mainNode = mainNode.Next;

            buttonIndex++;
        }

        if (count > GameManager.Instance.sameNode) GameManager.Instance.score += 5;
        else GameManager.Instance.score -= 10;

        GameManager.Instance.sameNode = count;
        
        if (count == 16) MenuManager.Instance.EndGame();

        return count;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slice : MonoBehaviour
{
    public void Click()
    {
        if (!FileManager.Instance.first) FileManager.Instance.first = this.gameObject;
        else
        {
            FileManager.Instance.second = this.gameObject;
            FileManager.Instance.Swap();
        }
    }
}

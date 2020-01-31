using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CounterScript : MonoBehaviour
{
    public int count;
    public Text countText;
    public Text winText;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
        
    }

    // Update is called once per frame
   public void Counterincrementer()
    {
        count = count + 1;
        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 14)
        {
            winText.text = "You Win!";
        }
    }
}

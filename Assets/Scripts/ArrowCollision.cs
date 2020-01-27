using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowCollision : MonoBehaviour
{
    public Collider targetCollider;

    private int count;
    public Text countText;
    public Text winText;



    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("pickup"))
        {
            collision.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
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



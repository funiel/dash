using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class scoreboard : MonoBehaviour
{

    private int count;
    public Text countText;

    void Start()
    {
        count = 0;
        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            count = count + 1;
            SetCountText();
        }
    }
}
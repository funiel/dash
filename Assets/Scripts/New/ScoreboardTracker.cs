using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ScoreboardTracker: MonoBehaviour
{

    private int count;
    private int lives;
    public Text countText;
    public Text livesText;

    private void Start()
    {
        count = 0;
        lives = 3;
        SetCountText();
        SetLivesText();
    }

    private void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }

    private void SetLivesText()
    {
        livesText.text = "Lives: " + lives.ToString();
    }

    private void Update() {
        if (lives == 0)
        {
            SceneManager.LoadScene("Testisgut1");
        };
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            if (GetComponent<Dash>().dashState == Dash.DashState.Dashing)
            {
                count = count + 1;
                SetCountText();
            } else {
                lives = lives - 1;
                SetLivesText();
            }
        }
    }
}
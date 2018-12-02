using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Text timerText;
    public Text winText;
    public Text endText;
    private Rigidbody2D rb2d;

    void Start()
    {
        winText.text = "";
        endText.text = "";
        timerText.text = "";

    }
    void FixedUpdate()
    {
        timer = timer + Time.deltaTime;
        if (timer >= 10)
        {
            endText.text = "You Lose! :(";
            StartCoroutine(ByeAfterDelay(2));
        }

    }

    IEnumerator ByeAfterDelay(float time)
    {
        yield return new WaitForSeconds(time);
        GameLoader.gameOn = false;
    }
   
    void SetCountText()
    {
        if (count >= 10)
        {
            endText.text = "You win!";
            StartCoroutine(ByeAfterDelay(2));
        }
        GameLoader.AddScore(10);
    }
}
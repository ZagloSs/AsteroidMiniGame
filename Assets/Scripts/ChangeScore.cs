using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeScore : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI txt;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            changeScore();
        }
    }

    public void changeScore()
    {
        score++;
        txt.text = score.ToString();
    }
}

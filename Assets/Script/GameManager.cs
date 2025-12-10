using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public int ScoreCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreGUI();
    }

    public void MenambahScore()
    {
        ScoreCount++;
        UpdateScoreGUI();
    }

    void UpdateScoreGUI()
    {
        ScoreText.text = "Score: " + ScoreCount.ToString();
    }
}

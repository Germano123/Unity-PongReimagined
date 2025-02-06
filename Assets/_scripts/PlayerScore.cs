using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public TextMeshProUGUI scoretext;

    public int score = 0;

    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        // TODO: update score ui
        scoretext.text = score.ToString();
    }

    public void GainScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    public void LoseScore(int amount)
    {
        score -= amount;
        UpdateUI();
    }
}

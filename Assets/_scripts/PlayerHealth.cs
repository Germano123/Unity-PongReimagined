using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public TextMeshProUGUI healthtext;

    public int health = 3;
    public int maxhealth = 5;

    void Start()
    {
        UpdateUI();
    }

    public void GainHealth()
    {
        if (this.health < maxhealth)
        {
            UpdateUI();
            this.health++;
        }
    }

    public void TakeDamage()
    {
        this.health--;
        UpdateUI();
        if (this.health == 0)
        {
            // TODO: game over
        }
    }

    void UpdateUI()
    {
        healthtext.text = health.ToString();
    }
}

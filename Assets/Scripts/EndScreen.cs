using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeper scoreKeper;

    void Awake()
    {
        scoreKeper = FindObjectOfType<ScoreKeper>();
    }

    public void ShowScore()
    {
        finalScoreText.text = "Congratulations!\nYou got a score " + scoreKeper.CalculateScore() + " % ";
    }

}


using UnityEngine;
using TMPro; // Wajib untuk mengakses komponen TextMeshPro

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton agar mudah diakses
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        instance = this; // Atur singleton
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
}



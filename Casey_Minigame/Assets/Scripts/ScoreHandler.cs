using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    public static ScoreHandler instance { get; private set; }
    private int health = 10;
    public TextMeshProUGUI HealthBar;
    public TextMeshProUGUI loseBox;
    void Start()
    {
        loseBox.gameObject.SetActive(false);
        UpdateScore();
    }

    void UpdateScore()
    {
        HealthBar.text = "Health: " + health;
    }
    public void HealthGoDown()
    {
        health += -1;
        UpdateScore();
    }
    public void Lose()
    {
       loseBox.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (health == 0) {
            Lose();
        }
    }
}

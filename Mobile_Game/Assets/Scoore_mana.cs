using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoore_mana : MonoBehaviour
{
    public static Scoore_mana instance;

    public Text ScoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // when the game starts it will be 0 points 
    void Start()
    {
        ScoreText.text = score.ToString() + " POINTS";

    }


    // when the player collects one berry it will change the points on the scoreboard 
    public void AddPoint()
    {
        score += 1;
        ScoreText.text = score.ToString() + " POINTS";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

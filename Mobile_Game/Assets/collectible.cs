using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;
public class collectible : MonoBehaviour
{
    public int Score = 0;
    public Text ScoreText;
    public static collectible instance;
    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreText.text = Score.ToString() + " score";
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            FindAnyObjectByType<Scoore_mana>().AddPoint();
            Score++;
            Destroy(other.gameObject);
        }
    }
    public void AddPoint()
    {
        Score += 1;
        ScoreText.text = Score.ToString() + " score";
    }
}

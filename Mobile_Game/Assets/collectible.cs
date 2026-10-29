using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class collectible : MonoBehaviour
{
    public int Score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            Score++;
            Destroy(other.gameObject);
        }
    }
}

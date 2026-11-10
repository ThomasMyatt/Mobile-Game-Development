using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 spawnLocation;
    public Rigidbody2D rb;
    public void ResetPlayerPos()
    {
        transform.position = spawnLocation; 
    }
    public void UpdatePlayerSpawn(Vector3 updatedSpawn)
    {
        spawnLocation = updatedSpawn;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spawnLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            UpdatePlayerSpawn(spawnLocation);
        }
    }
}

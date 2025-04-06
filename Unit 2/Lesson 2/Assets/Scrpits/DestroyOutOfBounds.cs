using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30;
    public float lowerBound = -20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // If the object is above the upper bound, destroy it
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        // If the object is below the lower bound, destroy it and log "Game Over!"
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}

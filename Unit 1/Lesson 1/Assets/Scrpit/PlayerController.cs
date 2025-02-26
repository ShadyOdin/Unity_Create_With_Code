using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    
    public float speed = 500;
    void Update()
    {
        // Move the Vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
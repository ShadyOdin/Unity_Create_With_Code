using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20f;
    private PlayerCtrler PlayerCtrlerScript;
    private float leftBound = -10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerCtrlerScript = GameObject.Find("Player").GetComponent<PlayerCtrler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerCtrlerScript.gameOver == false)
        {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}

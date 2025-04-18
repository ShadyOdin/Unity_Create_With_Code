using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30f;
    private PlayerCtrler PlayerCtrlerScript;
    private float bottomBound = -2f;
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

        if (transform.position.y < bottomBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}

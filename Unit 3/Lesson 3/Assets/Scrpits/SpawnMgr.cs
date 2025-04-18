using UnityEngine;

public class SpawnMgr : MonoBehaviour
{
    public GameObject obstiaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2f;
    private PlayerCtrler PlayerCtrlerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, Random.Range(1f, 2.5f));
        PlayerCtrlerScript = GameObject.Find("Player").GetComponent<PlayerCtrler>();
    }

    void SpawnObstacle ()
    {
        if(PlayerCtrlerScript.gameOver == false)
        {
        Instantiate(obstiaclePrefab, spawnPos, obstiaclePrefab.transform.rotation);
        }    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}

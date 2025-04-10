using UnityEngine;

public class SpawnMgr : MonoBehaviour
{
    public GameObject obstiaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle ()
    {
        Instantiate(obstiaclePrefab, spawnPos, obstiaclePrefab.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}

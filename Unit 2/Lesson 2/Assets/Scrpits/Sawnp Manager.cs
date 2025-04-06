using UnityEngine;

public class SawnpManager : MonoBehaviour
{
    public GameObject[]animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 30;
    private float startDelay = 2;
    private float spawnInterveral = 1.5f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterveral);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
       
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}

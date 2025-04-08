using UnityEngine;

public class SawnpManager : MonoBehaviour
{
    public GameObject[]animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 30;
    private float startDelay = 4;
    private float spawnInterveral = 1.6f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterveral);
    }

    // Update is called once per frame
    void Update()
    {

    }
    /// SpawnRandomAnimal is a method that spawns a random animal prefab at a random position within the specified range
    /// The method is called repeatedly at a specified interval using InvokeRepeating
    private void SpawnRandomAnimal()
    {
        // Random.Range is used to generate a random number between 0 and the length of the animalPrefabs array
        // This random number is used to select a random animal prefab from the array
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
       
        // Instantiate is used to create a new instance of the selected animal prefab at the specified spawn position and rotation
        // The rotation is set to the prefab's original rotation
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}

using UnityEngine;

public class cowsnek : MonoBehaviour
{
    public GameObject[]animalPrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
           
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0 , 20), animalPrefabs[animalIndex].transform.rotation);
        }        
        if (Input.GetKeyUp(KeyCode.S))
        {
           
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0 , 20), animalPrefabs[animalIndex].transform.rotation);
        }        
    }
}

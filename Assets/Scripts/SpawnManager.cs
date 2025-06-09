using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private int spawnRangeX = 10;
    private int spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            SpawnRandomAnimal();
        }
    }
    void SpawnRandomAnimal(){
        int index;
        index = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(
            animalPrefabs[index], spawnPos,
            animalPrefabs[index].transform.rotation
        );
    }
}

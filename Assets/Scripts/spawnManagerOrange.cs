using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager2 : MonoBehaviour
{


    public GameObject[] animalPrefabs;
    [SerializeField] private float spawnRangeX = 10;
    [SerializeField] private float spawnPosZ = 20;
    [SerializeField] private float startDelay = 2.0f;
    [SerializeField] private float spawnInterval = 1.5f;
    [SerializeField] private float redPosX = 0.2f;
   
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
         //Randomly generate animal index and spawn position
            Vector3 spawnPos = new Vector3(redPosX,0,spawnPosZ);

            int animalIndex = Random.Range(0,animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}

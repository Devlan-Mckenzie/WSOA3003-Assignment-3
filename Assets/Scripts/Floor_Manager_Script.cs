using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Manager_Script : MonoBehaviour
{
    public GameObject[] floors;
    public float spawnTime = 2f;
    public GameObject spawnPoint;
    private float elapsedTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= spawnTime)
        {
            elapsedTime = 0f;
            SpawnFloorPiece();
        }
    }
    void SpawnFloorPiece()
    {
        GameObject FloorPiece = Instantiate(floors[Random.Range(0, 4)], spawnPoint.transform);
    }
}

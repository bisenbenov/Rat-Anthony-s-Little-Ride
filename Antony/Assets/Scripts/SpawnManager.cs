using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RatRoadSpawner roadSpawner;

    void Start()
    {
        roadSpawner = GetComponent<RatRoadSpawner>();   
    }
    
    public void OnSpawnTriggerEnter()
    {
        roadSpawner.MoveRatRoad();
    }
}

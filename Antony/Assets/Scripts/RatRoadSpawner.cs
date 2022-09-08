using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RatRoadSpawner : MonoBehaviour
{
    public List<GameObject> roads;

    private float offset = 200f;

    private void Start()
    {
        if (roads != null && roads.Count > 0)
        {
            roads = roads.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    public void MoveRatRoad()
    {
        GameObject movedRatRoad = roads[0];

        roads.Remove(movedRatRoad);
        
        float newZ = roads[roads.Count - 1].transform.position.z + offset;
        movedRatRoad.transform.position = new Vector3(0, 0, newZ);

        
        roads.Add(movedRatRoad);
    }
}

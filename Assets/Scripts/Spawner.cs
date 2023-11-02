using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> spawnList;
    [SerializeField] private float _timeBetweenSpawn;
    private float _time;
    
    void Update()
    {
        if (Time.time > _time)
        {
            int rnd = Random.Range(0, spawnList.Count);

            Spawn(spawnList[rnd]);
            
            _time = Time.time + _timeBetweenSpawn;
        }
    }
    private void Spawn(GameObject gameObject)
    {
        float y = Random.Range(-3.75f, 3.75f);
        Instantiate(gameObject, new Vector3(12, y, 0), new Quaternion(0, 0, 0, 0));
    }
}

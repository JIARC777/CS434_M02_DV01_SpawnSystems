using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClient : MonoBehaviour
{

    public Drone drone;
    public Sniper sniper;
    public Tank tank;
    public EnemySpawner spawner;
    

    private Enemy spawn;
    private int droneIncrementor = 0;
    private int sniperIncrementor = 0;
    private int tankIncrementor = 0;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            spawn = spawner.SpwanEnemy(drone);
            spawn.name = "Drone_Clone_" + ++droneIncrementor;
            spawn.transform.Translate(Vector3.forward * droneIncrementor * 1.5f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            spawn = spawner.SpwanEnemy(sniper);
            spawn.name = "Sniper_Clone_" + ++sniperIncrementor;
            spawn.transform.Translate(Vector3.forward * sniperIncrementor * 1.5f);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            spawn = spawner.SpwanEnemy(tank);
            spawn.name = "Tank_Clone_" + ++sniperIncrementor;
            spawn.transform.Translate(Vector3.forward * tankIncrementor * 1.5f);
        }
    }
}

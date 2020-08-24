using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNSPHERES : MonoBehaviour
{
    public bool KeepSpawn { get; set; }
    private bool ToggledTimeScale { get; set; }
    public GameObject ToSpawnPrefab;
    private void Start()
    {
        KeepSpawn = true;
        InvokeRepeating("CreateNewBall", 0f, 3.6204f);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            KeepSpawn = !KeepSpawn;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Time.timeScale = 1f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Time.timeScale = 2f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Time.timeScale = 10f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Time.timeScale = 30f;
        }
    }
    public void CreateNewBall()
    {
        if (KeepSpawn)
        {
            
            GameObject toInstantiate = ToSpawnPrefab;
            Instantiate(toInstantiate, gameObject.transform.position, Quaternion.identity);
        }
        
    }
}

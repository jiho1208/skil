using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] BloodCell;
    public Vector3 spawnvalue;
    public int CntBloodCell;

    public float spawnWait;
    public float startWait;
    public float waveWait;
    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    void Update()
    {
        
    }

    IEnumerator SpawnWave()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for(int i = 0; i < CntBloodCell; i++)
            {
                GameObject bc = BloodCell[Random.Range(0, BloodCell.Length)];
                Vector3 spawnPoint = new Vector3(Random.Range(-spawnvalue.x, spawnvalue.y),
                    spawnvalue.y, spawnvalue.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(bc, spawnPoint, spawnRotation);
                yield return new WaitForSeconds(waveWait);
            }
        }
    }
}

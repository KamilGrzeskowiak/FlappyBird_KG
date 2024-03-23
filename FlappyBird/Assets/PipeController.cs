using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
  
{
    public float Speed;
    public Transform SpawnPoint;
    public Transform DespawnPoint;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);
        if(transform.position.x < DespawnPoint.x)
        {
            transform.position = new Vector3(SpawnPoint.position.x, transform.position.y, transform.position.z);
        }
    }
}

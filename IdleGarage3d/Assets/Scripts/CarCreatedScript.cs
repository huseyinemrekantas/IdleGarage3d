using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCreatedScript : MonoBehaviour
{
    public GameObject CarPrefabs;
    public int time = 1;

    short[] CarCreatedTime = {353 ,271 ,227, 179 ,137, 97, 37 , 29 };
    public static int i = 0;
    private void Start()
    {
        Instantiate(CarPrefabs, transform.position, transform.rotation);
    }
    void Update()
    {
        time += 1;
        if (time%CarCreatedTime[i] == 0)
        {
            Instantiate(CarPrefabs, transform.position, transform.rotation);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarWayPath : MonoBehaviour
{
    public GameObject Car;

    private void Start()
    {
        Car.transform.position += Car.transform.forward * Time.deltaTime;
    }

    /*public static void Movementx2()
    {
        Car.transform.position -= Car.transform.forward * Time.deltaTime *2;
        if (Car.transform.position.z < -2)
        {
            Destroy(Car);
        }
    }*/
    private void Update()
    {
        Car.transform.position += Car.transform.forward * Time.deltaTime;
        if (Car.transform.position.z < -2)
        {
            Destroy(Car);
        }
    }
}

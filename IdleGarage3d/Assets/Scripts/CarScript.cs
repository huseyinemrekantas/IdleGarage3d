using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarScript : MonoBehaviour
{
    public static int speed = 2;
    public static int speedLevel = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0,0);
        if (transform.position.z < -8)
        {
            Destroy(this.gameObject);
        }
    }
    
}

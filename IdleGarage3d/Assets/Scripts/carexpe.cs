using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Car Experience", menuName = "Experience", order = 1)]
public class carexpe : ScriptableObject
{
    public float price;
    private int level;
    public float factor;//katsayı
    public float _earncoin;
}

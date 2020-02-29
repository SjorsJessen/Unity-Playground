using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structs : MonoBehaviour
{
    private void Start()
    {
        Car mercedes;
        mercedes.Brand = "Mercedes";
        mercedes.Model = "AMG";
        mercedes.CarColor = Color.black;
        mercedes.Cost = 30000f;
        
        Debug.Log(mercedes.Brand + mercedes.Model + mercedes.CarColor + mercedes.Cost);
    }
}

public struct Car
{
    public string Brand;
    public string Model;
    public Color CarColor;
    public float Cost;
}

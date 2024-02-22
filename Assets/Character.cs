using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public string name;
    private int healthPoint = 1;

    public int HealthPoint { get => healthPoint; set => healthPoint = value; }

    public Character (string name)
    {
        this.name = name;
        Debug.Log("Hola, soy" + this.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    ~Character ()
    {
        Debug.Log("Destroyed.");
    }
}

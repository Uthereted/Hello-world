using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    private int healthPoints = 1;


    public Character(string s)
    {
        name = s;
        Debug.Log(name);
    }

    ~Character()
    {
        Debug.Log(name + " dead");
    }

    public int HealthPoints { get => healthPoints; set => healthPoints = value; }
}
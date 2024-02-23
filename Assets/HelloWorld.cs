using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    Enemy e;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        e = new Enemy("Bob");
        Player p = new Player("Pepe");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Nombre: " + e.name + ", Vida: " + e.HealthPoints);
    }
}

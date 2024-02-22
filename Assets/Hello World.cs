using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy = new Enemy(" Vol");
        Player player = new Player(" HP");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Name: ", enemy.name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocatePosition : MonoBehaviour
{
    public float velocidad = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PosicionSpace();

        checkMovement();

        checkSacle();

        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(Vector3.up * -velocidad * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(Vector3.up * velocidad * Time.deltaTime);
        }
    }

    private void checkSacle()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.localScale += new Vector3(1, 0, 0);
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            transform.localScale += new Vector3(0, 1, 0);
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            transform.localScale += new Vector3(0, 0, 1);
        }

        else if (Input.GetKeyDown(KeyCode.V))
        {
            transform.localScale -= new Vector3(1, 1, 1);
        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            transform.localScale += new Vector3(1, 1, 1);
        }
    }

    private void PosicionSpace()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Posicion X: " + this.transform.position.x);
            Debug.Log("Posicion Y: " + this.transform.position.y);
            Debug.Log("Posicion Z: " + this.transform.position.z);
        }
    }

    void checkMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
    }
}

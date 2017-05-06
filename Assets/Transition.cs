using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{

    public string Level;
    public bool button;

    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Application.LoadLevel(Level);
    }

    void OnMouseDown()
    {
        if (button)
            Application.LoadLevel(Level);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

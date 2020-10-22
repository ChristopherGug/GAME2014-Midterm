/**********************************************************************************************
 * Name: "Christopher Gugelmeier"                                                             *
 * Student ID: "101175944"                                                                    *
 * File name: "BackgroundController"                                                          *
 * Date last modified: "2020-10-21"                                                           *
 * Script Description: "This script is responsible for the movement of the background image"  *
 **********************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.y <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}

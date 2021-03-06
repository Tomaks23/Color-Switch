﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMove : MonoBehaviour
{
    public float speed = 100;
    public float rangeMax = 10;
    public float direction = 1;
    public float initialPositionX;
    void Start()
    {
        initialPositionX = this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector2(
            this.transform.position.x + (direction * Time.deltaTime * speed)
            ,this.transform.position.y);
        if (this.transform.position.x > initialPositionX + rangeMax)
        {
            direction = -1;

        }
        if (this.transform.position.x < initialPositionX - rangeMax)
        {
            direction = 1;
        }
    }
}

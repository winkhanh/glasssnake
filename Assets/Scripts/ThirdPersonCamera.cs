﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {
    public float speed = 1;
    public Transform target;
    public Camera cam;
    public GameObject snake;
    public SnakeBehavior flag;
    
	void LateUpdate () {
        flag = snake.GetComponent<SnakeBehavior>();
        if (flag.ifAlive)
        Move();
	}
    
    public void Move()
    {
        Vector3 pos = target.position;
        pos.y = 0;
        transform.position = pos;
        transform.rotation = target.rotation;

    }
}

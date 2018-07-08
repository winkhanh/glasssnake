﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunlight : MonoBehaviour {
    public Vector3 center;
    
    public float range;
    public float speed;
    // light is set using unity-editor
    public GameObject light;
	// Update is called once per frame

	void Update () {
        move(); 
	}
    void move()
    {
        Vector3 temp;
        temp.x = Mathf.Sin(Time.time/speed) * range;
        temp.z = center.z;
        temp.y = Mathf.Cos(Time.time/speed) * range;
        light.transform.position = temp;
    }
}

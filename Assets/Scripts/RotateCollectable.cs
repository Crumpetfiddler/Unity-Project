﻿using UnityEngine;
using System.Collections;

public class RotateCollectable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 0) * Time.deltaTime);
    }

}

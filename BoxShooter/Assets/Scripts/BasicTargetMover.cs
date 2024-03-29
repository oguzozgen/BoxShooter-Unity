﻿using UnityEngine;
using System.Collections;

public class BasicTargetMover : MonoBehaviour {

    public float spinSpeed = 180.0f;
    public float motionMagnetude = 0.1f;
    public bool doSpin = true;
    public bool doMotion = false;
	// Update is called once per frame
	void Update () {
        if (doSpin)
        {//for rotation
        gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
            
        }
        if (doMotion)
        {
                //for movement
        gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnetude);
        }
        
	
	}
}

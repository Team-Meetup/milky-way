﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PopsicleController>().iceCount++;
            GameObject.FindGameObjectWithTag("SFXAudioSource").GetComponent<SFXController>().IceCubeHit();
            Destroy(gameObject);
        }
    }
}

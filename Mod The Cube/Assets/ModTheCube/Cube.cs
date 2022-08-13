﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float rotationSpeed = 30;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;

        Material material = Renderer.material;

        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);

        InvokeRepeating("ChangeColor", 1.0f, 1.0f);
    }

    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime * rotationSpeed, 0.0f, 0.0f);
    }

    void ChangeColor()
    {
        Renderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1.0f);
    }


}

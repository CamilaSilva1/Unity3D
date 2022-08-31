// Created By Camila Silva
// Since 10/08/2022
// This script é responsable to the movement bird
// this script is on object Player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Move : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){

            rig.velocity = Vector2.up * speed;

        }
    }
}

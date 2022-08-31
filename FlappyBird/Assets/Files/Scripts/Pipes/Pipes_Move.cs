// Created By Camila Silva
// Since 10/08/2022
// This script é responsable to the movement pipes
// this script is on prefab Pipes_Slot

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes_Move : MonoBehaviour
{
   public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}

// Created by Camila Silva
// Since 19/08/2022
// This script is responsable for ground scroll 
// This script is on object in scene with the name Ground

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMoveGround : MonoBehaviour
{
    [SerializeField]
    private MeshRenderer mrGround;

    [SerializeField]
    private float speedOffsetGround;


    // Update is called once per frame
    void Update()
    {
        mrGround.material.mainTextureOffset += new Vector2(speedOffsetGround * Time.deltaTime, 0);
    }
}

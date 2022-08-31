// Created By Camila Silva
// Since 10/08/2022
// This script é responsable to spawn pipes
// This script is on object SpawnPipes

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    [SerializeField]
    private GameObject pipe;

    [SerializeField]
    private float height;

    [SerializeField]
    private float maxTimeCreatePipes;
    
    private float countTimer;

    public static SpawnPipes instanceSpawnPipes;


    // Start is called before the first frame update
    void Start()
    {   
        instanceSpawnPipes = this;
        // instanciando um novo cano em cena
        // GameObject newPipe = Instantiate(pipe);

        // inserindo a posição para esse novo cano instanciado
        // recebera a propria posição do cano + uma nova posição no vector 3 usando valor randomico no eixo Y
        // newPipe.transform.position = transform.position = new Vector3(2.2f, Random.Range(-height, height), 0.07820067f);
    }

    // Update is called once per frames
    void Update()
    {
        if(countTimer > maxTimeCreatePipes){
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position = new Vector3(2.2f, Random.Range(-height, height), 0.07820067f);
            Destroy(newPipe, 10f);
            countTimer = 0;
        }

        countTimer += Time.deltaTime;
    }
}

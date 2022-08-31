// Created by Camila Silva
// Since 25/08/2022
// This script is responsable for Get score of the game
// this script is on Object GameOverPanel on Main Scene

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GettingScore : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreTxt, bestScoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        scoreTxt.text = ColliderManager.score.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = ColliderManager.score.ToString();

        if(ColliderManager.scoreTotal > ColliderManager.score){
            bestScoreTxt.text = ColliderManager.scoreTotal.ToString();
        }
    }
}

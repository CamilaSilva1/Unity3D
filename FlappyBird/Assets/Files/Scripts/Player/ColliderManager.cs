// created by Camila Silva
// Since 16/08/2022
// This script is responsable for game over when the player collider the pipes
// This script is on object Player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColliderManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverPanel;

    [SerializeField]
    private TextMeshProUGUI scoreTxt;

    public static int score, scoreTotal;

    [SerializeField]
    private float forceValue;

    public static ColliderManager instanceScore;


    void Start(){
        instanceScore = this;

        scoreTotal = PlayerPrefs.GetInt("ScoreTotal");

        scoreTxt.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Enemy"){
            Debug.Log("colidiu");
            gameOverPanel.SetActive(true);

            Time.timeScale = 0;
        }

        if(col.gameObject.tag == "ScoreCollider"){
            ScoreFunction();
        }
    }

    void ScoreFunction(){
        score++;
        scoreTotal++;

        scoreTxt.text = score.ToString();

        PlayerPrefs.SetInt("ScoreTotal", scoreTotal);
    }

}

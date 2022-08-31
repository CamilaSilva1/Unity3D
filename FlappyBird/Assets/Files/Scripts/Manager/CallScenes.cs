// Created by Camila Silva
// Since 25/08/2022
// This script is responsable for manager the function of the game
// This script is on Canvas in Menu Scene

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CallScenes : MonoBehaviour
{
    // Start is called before the first frame update
   public void startGame(){
    SceneManager.LoadScene("Main");
   }
}

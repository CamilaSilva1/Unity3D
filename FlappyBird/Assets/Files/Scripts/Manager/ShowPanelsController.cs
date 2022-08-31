// created by Camila Silva
// Since 17/08/2022
// This script is responsable for manager panels
// This script is on object ManagerShowPanels

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowPanelsController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject gameOverPanel;

    [SerializeField]
    private GameObject getStartPanel;

    [SerializeField]
    private Rigidbody2D playerRB;

   void Start(){
     SpawnPipes.instanceSpawnPipes.enabled = false;
   }

   void Update(){
     if(Input.GetMouseButtonDown(0) && getStartPanel.activeInHierarchy){
          getStartPanel.SetActive(false);

     }
     if(!getStartPanel.activeInHierarchy){
          SpawnPipes.instanceSpawnPipes.enabled = true;
          playerRB.GetComponent<Rigidbody2D>().simulated = true;
     }
   }

     public void restarGame(){

        gameOverPanel.SetActive(false);
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }

    public void ExitGame(){
      
    }
}

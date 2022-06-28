using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Master : MonoBehaviour
{
    void Start()
    {
          Invoke("LoadMaster" ,36);
    }

    void Update(){
      
    if (Input.GetKeyDown(KeyCode.Space)) {
   
           SceneManager.LoadScene("game");
           } 
    }
      public void LoadMaster() {
       SceneManager.LoadScene("game");
   }
}

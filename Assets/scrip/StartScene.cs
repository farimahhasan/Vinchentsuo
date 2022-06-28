using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    void Start()
    {
          Invoke("LoadMaster" ,7);

    }
    void Update(){
      
    if (Input.GetKeyDown(KeyCode.Space)) {
              SceneManager.LoadScene("cave");
        } 
    }

      public void LoadMaster() {
       SceneManager.LoadScene("cave");
   }




}

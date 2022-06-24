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

      public void LoadMaster() {
       SceneManager.LoadScene("cave");
   }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hybnotizm : MonoBehaviour
{
    void Start()
    {
          Invoke("LoadMaster" ,6);
    }

      public void LoadMaster() {
       SceneManager.LoadScene("master");
   }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Front : MonoBehaviour
{
    public bool attack=false;

         public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="vin")
        {
           attack=true;

        }

    }
    public void OnTriggerExit2D(Collider2D collision){
       attack=false;

    }
}

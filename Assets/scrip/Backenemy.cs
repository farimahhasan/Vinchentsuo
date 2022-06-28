using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backenemy : MonoBehaviour
{


    public int healthNumber = 2;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="vin")
        {

            healthNumber--;

        }

    }
}

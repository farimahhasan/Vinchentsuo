using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{

    public float speed = 3f;
    public float velocity;
    public float links;
    private Vector3 rotation;
    private Animator anim;
    private bool attack=false;
    public int healthNumber = 4;
    public GameObject enemys;
    void Start()
    {
        velocity = transform.position.x + velocity;
        links = transform.position.x - links;
        anim = GetComponent<Animator>();

    }


    
         private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="vin")
        {
            anim.SetBool("attack",true);

            healthNumber--;
            if(healthNumber==0){
             anim.SetBool("die",true);
            Invoke("hideenemy" ,1);

            }

           attack=true;

        }

    }
    private void OnTriggerExit2D(Collider2D collision){
       anim.SetBool("attack",false);
       attack=false;

    }
     
     public void hideenemy(){
        enemys.SetActive(false);
     }


    void Update()
    {
       if(!attack){
        transform.Translate(Vector3.left * speed * Time.deltaTime);
            anim.SetBool("moving",true);
            anim.SetBool("attack",false);


        if (transform.position.x < links) {
            transform.eulerAngles = rotation - new Vector3(0,180,0);

        }

        if (transform.position.x > velocity) {
            transform.eulerAngles = rotation ;

        }
       }

    
    }
}


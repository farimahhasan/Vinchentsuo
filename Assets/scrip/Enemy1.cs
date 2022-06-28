using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public AudioSource sound;

    public float speed = 1f;
    public float velocity;
    public float links;
    private Vector3 rotation;
    private Animator anim;

    public GameObject enemys;

    public GameObject back;
    public GameObject front;

    void Start()
    {
        velocity = transform.position.x + velocity;
        links = transform.position.x - links;
        anim = GetComponent<Animator>();

    }


    void Update()
    {

        if(front.GetComponent<Front>().attack==true){
           anim.SetBool("attack",true);
        }
        else{
            anim.SetBool("attack",false);
        }

       if(!(front.GetComponent<Front>().attack)){
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

          if(back.GetComponent<Backenemy>().healthNumber==0){
            anim.SetBool("die",true);
            sound.Play();
            Invoke("hide" ,1);

          }

    }

    public void hide(){
        enemys.SetActive(false);
    }

    
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{



    public float speed = 5;
    private Rigidbody2D rb;


    private Animator anim;
    private Animator anim2;

    private Vector3 rotation;


    public GameObject camera;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;

    public int healthNumber = 6;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim2 = GetComponent<Animator>();

        rotation = transform.eulerAngles;
      
    }

    void Update()
    {
        float direction = Input.GetAxis("Horizontal");

        if (direction != 0) {
            anim.SetBool("isRunning" , true);
        } else {
            anim.SetBool("isRunning" , false);
        }

        if (direction < 0) {
            transform.eulerAngles = rotation - new Vector3(0,180,0);
            transform.Translate(Vector2.right * speed * -direction * Time.deltaTime);
        }
        if (direction > 0) {
            transform.eulerAngles = rotation;
            transform.Translate(Vector2.right * speed * direction * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            anim.SetBool("isAttack", true);
        } 
         else {
            anim.SetBool("isAttack", false);
        } 


        camera.transform.position = new Vector3(transform.position.x , 0 , -10);
    }
 

          private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="enemy")
        {
            healthNumber--;
            if(healthNumber==0){
             anim.SetBool("die",true);
            Invoke("Loadgameover" ,1);

            }
        }

    }

          public void Loadgameover() {
       SceneManager.LoadScene("gameover");
   }



/* 
          private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="finish")
        {
            if(enemy1.SetActive==false){

            }

            Invoke("Loadgameover" ,1);

            }
        }

    } */








          public void Loadvictory() {
       SceneManager.LoadScene("victory");
   }

}

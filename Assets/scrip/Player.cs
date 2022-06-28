using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{


    public AudioSource sound;

    public float speed = 5;
    private Rigidbody2D rb;


    private Animator anim;
    private Animator anim2;

    private Vector3 rotation;


    public GameObject camera;


    public int healthNumber = 3;

    public GameObject herat1;
    public GameObject herat2;
    public GameObject herat3;

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
        if (collision.gameObject.tag =="front")
        {
            healthNumber--;
            print(healthNumber);
            if(healthNumber==2){
                herat1.SetActive(false);
            }
            if(healthNumber==1){
                herat2.SetActive(false);
            }
           if(healthNumber==0){
            herat3.SetActive(false);
             anim.SetBool("die",true);
             sound.Play();
            Invoke("Loadgameover" ,1);

            }
        }
        

       if (collision.gameObject.tag =="Finish")
        {

            Invoke("Loadvictory" ,1);
        }

    }

          public void Loadgameover() {
       SceneManager.LoadScene("gameover");
   }



          public void Loadvictory() {
       SceneManager.LoadScene("victory");
   }

}

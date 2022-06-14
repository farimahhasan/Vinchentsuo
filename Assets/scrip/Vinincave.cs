using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vinincave : MonoBehaviour
{


    public float speed = 5;
    private Rigidbody2D rb;


    private Animator anim;
    private Vector3 rotation;

    public AudioSource soundWatch;
    public AudioSource defualt;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rotation = transform.eulerAngles;
        defualt.Play();

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


    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("watch"))
        {
            soundWatch.Play();
            Invoke("LoadMaster" , 1);
        }

    }

   public void LoadMaster() {
       SceneManager.LoadScene("master");
   }
 }
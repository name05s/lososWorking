
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{  
    [SerializeField] private float speed;
    [SerializeField] private float delay;
    private Rigidbody2D body;
    private Animator anim;
    private static IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("end");
    }

    bool pluszak = false;
    bool koszula = false;
    bool herbata = false;
    bool sluchawki = false;
    bool karma = false;

    bool ojciec = false;
    bool kot = false;
    bool babcia = false;
    bool siostra = false;
    bool dziecko = false;

    bool dojciec = false;
    bool dkot = false;
    bool dbabcia = false;
    bool dsiostra = false;
    bool ddziecko = false;

    private void Awake()
    {
        //grabbing references
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);


        //flip character
        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);
        anim.SetBool("walk", horizontalInput != 0);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.gameObject.tag == "npcbrat")
        {
            if (Input.GetKey(KeyCode.E) && !pluszak && !ddziecko)
            {
                collision.gameObject.GetComponent<npcbratController>().activatedialog();
                ddziecko = true;
            }
            else if (Input.GetKey(KeyCode.E) && pluszak)
            {
                collision.GetComponent<Animator>().SetBool("hasPluszak", Input.GetKey(KeyCode.E));
                dziecko = true;
            }

        }

        else if (collision.tag == "pluszak" && !pluszak)
        {
            if (Input.GetKey(KeyCode.E))
            {
                pluszak = true;
                collision.gameObject.GetComponent<obControllerpluszak>().activatedialog();
            }
        }

        else if (collision.gameObject.tag == "npcojciec")
        {
            if (Input.GetKey(KeyCode.E) && !koszula && !dojciec)
            {
                collision.gameObject.GetComponent<npsojciecController>().activatedialog();
                dojciec = true; 
            }
            else if (Input.GetKey(KeyCode.E) && koszula)
            {
                collision.GetComponent<Animator>().SetBool("haskoszula", Input.GetKey(KeyCode.E));
                ojciec = true;
            }

        }
        else if (collision.tag == "koszula" && !koszula)
        {
            if (Input.GetKey(KeyCode.E))
            {
           
                koszula = true;
                Destroy(GameObject.FindWithTag("koszula"));
                collision.gameObject.GetComponent<obControllerkoszula>().activatedialog();
            }



        }

        if (collision.gameObject.tag == "npcsiostra")
        {
            if (Input.GetKey(KeyCode.E) && !sluchawki && !dsiostra)
            {
                collision.gameObject.GetComponent<npcsiostraController>().activatedialog();
                dsiostra = true;
            }
            else if (Input.GetKey(KeyCode.E) && sluchawki)
            {
                collision.GetComponent<Animator>().SetBool("hassluchawki", Input.GetKey(KeyCode.E));
                siostra = true;
            }

        }
        else if (collision.tag == "sluchawki" && !sluchawki)
        {
            if (Input.GetKey(KeyCode.E))
            {
               
               sluchawki = true;
               Destroy(GameObject.FindWithTag("sluchawki"));
                collision.gameObject.GetComponent<obControllersluchawki>().activatedialog();
            }



        }

        if (collision.gameObject.tag == "npcbabcia")
        {
            if (Input.GetKey(KeyCode.E) && !herbata && !dbabcia)
            {
                collision.gameObject.GetComponent<npcbabciaController>().activatedialog();
                dbabcia = true;
            }
            else if (Input.GetKey(KeyCode.E) && herbata)
            {
                collision.GetComponent<Animator>().SetBool("hasherbata", Input.GetKey(KeyCode.E));
                babcia = true;
            }

        }
        else if (collision.tag == "herbata" && !herbata)
        {
            if (Input.GetKey(KeyCode.E))
            {

                herbata = true;
                collision.gameObject.GetComponent<obControllerherbata>().activatedialog();
            }



        }

        if (collision.gameObject.tag == "npckot")
        {
            if (Input.GetKey(KeyCode.E) && !karma && !dkot)
            {
                collision.gameObject.GetComponent<npckot>().activatedialog();
                dkot = true;
            }
            else if (Input.GetKey(KeyCode.E) && karma)
            {
                collision.GetComponent<Animator>().SetBool("haskarma", Input.GetKey(KeyCode.E));
                kot = true;
            }

        }
        else if (collision.tag == "karma" && !karma)
        {
            if (Input.GetKey(KeyCode.E))
            {

                karma = true;
                collision.gameObject.GetComponent<obControllerkarma>().activatedialog();
            }




        }


        if (siostra == true && babcia == true && kot == true && dziecko == true && ojciec == true)
        {
            StartCoroutine(WaitForSceneLoad());
        }

    }

  

}

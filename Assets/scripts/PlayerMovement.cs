
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;

    bool pluszak = false;
    bool koszula = false;
    bool herbata = true;
    bool sluchawki = false;
    bool karma = true;

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
            if (Input.GetKey(KeyCode.E) && !pluszak)
            {
                collision.gameObject.GetComponent<npcbratController>().activatedialog();
            }
            else
            {
                collision.GetComponent<Animator>().SetBool("hasPluszak", Input.GetKey(KeyCode.E));
            }

        }

        else if (collision.tag == "pluszak" && !pluszak)
        {
            if (Input.GetKey(KeyCode.E))
            {

                pluszak = true;
            }
        }

        else if (collision.gameObject.tag == "npcojciec")
        {
            if (Input.GetKey(KeyCode.E) && !koszula)
            {
                collision.gameObject.GetComponent<npsojciecController>().activatedialog();
            }
            else
            {
                collision.GetComponent<Animator>().SetBool("haskoszula", Input.GetKey(KeyCode.E));
                //anim.SetBool("haskoszula", true);
            }

        }
        else if (collision.tag == "koszula" && !koszula)
        {
            if (Input.GetKey(KeyCode.E))
            {
           
                koszula = true;
            }



        }

        if (collision.gameObject.tag == "npcsiostra")
        {
            if (Input.GetKey(KeyCode.E) && !sluchawki)
            {
                collision.gameObject.GetComponent<npcsiostraController>().activatedialog();
            }
            else
            {
                collision.GetComponent<Animator>().SetBool("hassluchawki", Input.GetKey(KeyCode.E));
            }

        }
        else if (collision.tag == "sluchawki" && !sluchawki)
        {
            if (Input.GetKey(KeyCode.E))
            {

                sluchawki = true;
            }



        }

        if (collision.gameObject.tag == "npcbabcia")
        {
            if (Input.GetKey(KeyCode.E) && !herbata)
            {
                collision.gameObject.GetComponent<npcbabciaController>().activatedialog();
            }
            else
            {
                collision.GetComponent<Animator>().SetBool("hasherbata", Input.GetKey(KeyCode.E));
            }

        }
        else if (collision.tag == "herbata" && !herbata)
        {
            if (Input.GetKey(KeyCode.E))
            {

                herbata = true;
            }



        }

        if (collision.gameObject.tag == "npckot")
        {
            if (Input.GetKey(KeyCode.E) && !karma)
            {
                collision.gameObject.GetComponent<npckot>().activatedialog();
            }
            else
            {
                collision.GetComponent<Animator>().SetBool("haskarma", Input.GetKey(KeyCode.E));
            }

        }
        else if (collision.tag == "karma" && !karma)
        {
            if (Input.GetKey(KeyCode.E))
            {

                karma = true;
            }



        }


    }
}

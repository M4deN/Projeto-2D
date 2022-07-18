using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPC : MonoBehaviour
{
    public float vel = 10;
    private Rigidbody2D rbd;
    private Animator anim;
    private bool dir = false;
    public float jump = 700;
    private bool chao = false;

    public LayerMask mascara;
    public GameObject pe;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        chao = false;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if (x < 0 && dir || x > 0 && !dir)
        {
            transform.Rotate(new Vector2(0, 180));
            dir = !dir;


        }

        if (x == 0)
            anim.SetBool("movimento", false);
        else
            anim.SetBool("movimento", true);

        rbd.velocity = new Vector2(x * vel, rbd.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && chao)
        {
            chao = false;
            transform.parent = null;
            rbd.AddForce(new Vector2(0, jump));
        }

        RaycastHit2D hit;
        hit = Physics2D.Raycast(pe.transform.position, -pe.transform.up,1f,mascara);

        if (hit.collider != null)
        {
            transform.parent = hit.collider.transform;
            chao = true;
        }
        
    }
}

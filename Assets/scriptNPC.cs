using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptNPC : MonoBehaviour
{
    public float vel = 4;
    private Rigidbody2D rbd;
    private bool dir = true;
    private Animator anim;
  
  
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 

        rbd.velocity = new Vector2(rbd.velocity.x* vel, rbd.velocity.y);
        
    }
}

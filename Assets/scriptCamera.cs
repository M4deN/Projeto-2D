using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    public GameObject pc;
    public float y_offSet = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(pc.transform.position.x, pc.transform.position.y + y_offSet, -10);
        transform.position = pos;
    }
}

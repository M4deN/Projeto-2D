using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlataforma : MonoBehaviour
{
    private Vector2 posIni;
    private float cont = 0;
    public float deslocamento = 1f;
    private float x_offset;
    private float y_offset;
    public float distX = 1;
    public float distY = 2;
    // Start is called before the first frame update
    void Start()
    {
        posIni = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        cont = cont + deslocamento * Time.deltaTime;

        if (cont > Mathf.PI * 2)
            cont = cont - Mathf.PI * 2;

        x_offset = Mathf.Sin(cont)*distX;
        y_offset = Mathf.Cos(cont)*distY;

        transform.position = new Vector2(posIni.x + x_offset, posIni.y + y_offset);
    }
}

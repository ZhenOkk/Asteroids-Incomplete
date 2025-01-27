using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;
    public float fuerzaMax = 100f;
    public float fuerzaMin = 50f;
    void Start()
    {
        // Ejercicio 2: Movimiento aleatorio:
        float random = Random.Range(fuerzaMax, fuerzaMin);
        float rotation = Random.Range(0f, 180f);

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(random, rotation));

            //Ejercicio 3: 
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, -random * rotation);
    }
}

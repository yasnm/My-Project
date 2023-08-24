using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float liikeNopeus = 10f;
    public float hyppyVoima = 10f;

    public bool mennaanAlas = false;
    public float korkeinPiste = 0f;
    public float nykyinenPiste = 0f;

    public Rigidbody keho;
    public float liike;
    // Start is called before the first frame update
    void Start()
    {
        mennaanAlas = false;
        korkeinPiste = 0f;
        nykyinenPiste = 0f;
        keho = GetComponent<Rigidbody>();

    }

    void Update()
    {
        liike = Input.GetAxis("Horizontal") * liikeNopeus;
    }

    void FixedUpdate()
    {
        nykyinenPiste = this.transform.position.y;
        if (nykyinenPiste > korkeinPiste && mennaanAlas == false) 
        {
            korkeinPiste = nykyinenPiste;

        }
        else
        {
            mennaanAlas = true;
        }
        
        
        
        
        Vector3 kehonliike = keho.velocity;
        kehonliike.x = liike;
        keho.velocity = kehonliike;
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Floor")
        {
            if (mennaanAlas == true)
            {
                Hyppy();
            }

        }
    }
    public void Hyppy()
    {
        mennaanAlas = false;
        korkeinPiste = nykyinenPiste;


        Vector3 hyppy = keho.velocity;
        hyppy.y = hyppyVoima;
        keho.velocity = hyppy;
    }


}

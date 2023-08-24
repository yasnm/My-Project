using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {

            Player pelaaja = collider.GetComponent<Player>();
            if (pelaaja.mennaanAlas == true && pelaaja.nykyinenPiste > this.transform.position.y)
            {
                pelaaja.Hyppy();
            }
        }
    }
}      

        
        

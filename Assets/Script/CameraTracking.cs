using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    public GameObject pelaaja;

     void Update()
    {
        if(pelaaja.transform.position.y > this.transform.position.y)
        {
            Vector3 siirto = new Vector3(this.transform.position.x, pelaaja.transform.position.y, -10);
            this.transform.position = siirto;
            {

            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject taso;


     void Start()
    {
        if(taso != null)
        {
            for(int i = 0; i < 30; i++)
            {
                Instantiate(taso, new Vector3(-3, 5 + 5* i, 0), Quaternion.identity);
            }
        }
        }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime*-1*velocidad,0,0);
    }
}



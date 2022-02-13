using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Burbuja : MonoBehaviour
{
    public int intentos = 20;
    public float velocidad = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,Time.deltaTime*1*velocidad,0);

    }

    private void OnCollisionEnter2D(Collision2D objeto) {
        if (objeto.gameObject.name=="Pared")
        {
            transform.position = new Vector3(Random.Range(-9,9),-5,0);
            intentos = intentos - 1;
        }   

        if (objeto.gameObject.name=="Jugador")
        {
            transform.position = new Vector3(Random.Range(-9,9),-5,0);
            intentos = intentos + 1;
        }

    }
}

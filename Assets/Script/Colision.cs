using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{

    private void Update() {
        if (Input.GetKeyDown("space"))
        {
            Time.timeScale = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D objeto) {
        if (objeto.gameObject.name=="Pared")
        {
            transform.position = new Vector3(10,Random.Range(-5,5),0);
        }
        if (objeto.gameObject.name=="Jugador")
        {
            Destroy(objeto.gameObject);
            Time.timeScale = 0;
        }
    }
}




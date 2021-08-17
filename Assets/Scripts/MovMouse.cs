using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovMouse : MonoBehaviour
{

    // Variable para gestionar la velocidad desde Unity
    public float speed = 5f;

    // Variable que establece el punto de destino
    Vector3 target;

    void Start()
    {
        // Inicialmente el punto de destino es la pocisión actual
        target = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Detectamos cuando hacemos click izquierdo
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Establecemos la z a 0 para que no se modifique la profundidad
            target.z = 0f;
        }

        // Movemos el objeto hacia el punto de destino a una velocidad establecida
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // Opticamente podemos debugear una línea con el trayecto a recorrer
        Debug.DrawLine(transform.position, target, Color.red);
    }
}

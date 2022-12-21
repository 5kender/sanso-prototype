using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // l'objet à suivre (le joueur, par exemple)
    public float smoothSpeed = 0.125f; // vitesse de suivi de la caméra
    public Vector3 offset; // décalage de la caméra par rapport à l'objet à suivre

    void Start()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = new Vector3(desiredPosition.x, desiredPosition.y, transform.position.z);
    }

    void LateUpdate()
    {
        // Calculer la position cible de la caméra en fonction de l'objet à suivre et du décalage
        Vector3 desiredPosition = target.position + offset;

        // Appliquer un suivi en douceur de la caméra vers la position cible
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
    }
}



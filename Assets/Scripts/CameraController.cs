using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // l'objet � suivre (le joueur, par exemple)
    public float smoothSpeed = 0.125f; // vitesse de suivi de la cam�ra
    public Vector3 offset; // d�calage de la cam�ra par rapport � l'objet � suivre

    void Start()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = new Vector3(desiredPosition.x, desiredPosition.y, transform.position.z);
    }

    void LateUpdate()
    {
        // Calculer la position cible de la cam�ra en fonction de l'objet � suivre et du d�calage
        Vector3 desiredPosition = target.position + offset;

        // Appliquer un suivi en douceur de la cam�ra vers la position cible
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
    }
}



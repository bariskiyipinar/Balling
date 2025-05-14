using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boyut : MonoBehaviour
{
    public Vector3 noktaA;      // Ba�lang�� noktas�
    public Vector3 noktaB;      // Gidece�i nokta
    public float hiz = 3f;

    private Vector3 hedef;

    void Start()
    {
        hedef = noktaB;  // �lk hedef B noktas�
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, hedef, hiz * Time.deltaTime);

        // E�er hedefe �ok yakla�t�ysa y�n� de�i�tir
        if (Vector3.Distance(transform.position, hedef) < 0.01f)
        {
            hedef = (hedef == noktaA) ? noktaB : noktaA;
        }
    }
}

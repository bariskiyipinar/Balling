using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boyut : MonoBehaviour
{
    public Vector3 noktaA;      // Baþlangýç noktasý
    public Vector3 noktaB;      // Gideceði nokta
    public float hiz = 3f;

    private Vector3 hedef;

    void Start()
    {
        hedef = noktaB;  // Ýlk hedef B noktasý
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, hedef, hiz * Time.deltaTime);

        // Eðer hedefe çok yaklaþtýysa yönü deðiþtir
        if (Vector3.Distance(transform.position, hedef) < 0.01f)
        {
            hedef = (hedef == noktaA) ? noktaB : noktaA;
        }
    }
}

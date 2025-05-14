using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public Vector3 hedefKonum;
    public float hiz = 5f;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, hedefKonum, hiz * Time.deltaTime);
    }
}

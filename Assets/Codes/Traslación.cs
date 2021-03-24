using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traslación : MonoBehaviour
{
    public string centro = "Sol";
    GameObject Centro;

    public float distancia = 1.0f;
    public float angulo = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Centro = GameObject.Find(centro);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarBoila : MonoBehaviour
{
    public int bola;
    // Start is called before the first frame update
    void Start()
    {
        bola = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Colisor)
    {
        if (Colisor.gameObject.CompareTag("bola"))
        {
            bola++;
            Destroy(Colisor.gameObject);
        }
    }
}

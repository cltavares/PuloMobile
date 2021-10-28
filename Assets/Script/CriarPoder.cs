using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriarPoder : MonoBehaviour
{
    public GameObject poder;
    public GameObject clone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.F1))
        {
            Instantiate(poder, new Vector3(cano.transform.position.x, cano.transform.position.y, cano.transform.position.z), Quaternion.identity);
        }*/

        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                clone = Instantiate(poder, transform.position, transform.rotation) as GameObject;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    public bool up;


    // Start is called before the first frame update
    void Start()
    {
        up = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 8.71) {
            up = false;
        } else if (transform.position.y < 4.71) {
            up = true;
        }

        if (up == true) {
            transform.position += Vector3.up * Time.deltaTime;
        } else {
            transform.position -= Vector3.up * Time.deltaTime;
        }
    }
}

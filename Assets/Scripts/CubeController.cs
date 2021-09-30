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
        if (transform.position.y > 2) {
            up = false;
        } else if (transform.position.y < -2) {
            up = true;
        }

        if (up == true) {
            transform.position += Vector3.up * Time.deltaTime;
        } else {
            transform.position -= Vector3.up * Time.deltaTime;
        }
    }
}

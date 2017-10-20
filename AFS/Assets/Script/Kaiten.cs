using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaiten : MonoBehaviour {

    bool direction;

    void Start()
    {
        direction = true;

    }

    void Update()
    {

        if (direction)
        {
            if (transform.eulerAngles.z < 365)
            {
                transform.Rotate(0, 0, 10 * Time.deltaTime);

            }
            if (Mathf.Round(transform.eulerAngles.z) == 365)
            {
                direction = !direction;
            }
        }

        if (!direction)
        {
            transform.Rotate(0, 0, -10 * Time.deltaTime);

            if (Mathf.Round(transform.eulerAngles.z) == 0)
            {
                direction = !direction;
            }
        }

    }
}

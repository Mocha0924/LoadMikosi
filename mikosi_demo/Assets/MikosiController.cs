using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MikosiController : MonoBehaviour
{
    // Start is called before the first frame update

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position += new Vector3(0.1f, 0, -0);
        }

    }
}

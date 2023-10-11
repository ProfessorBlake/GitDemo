using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
		if (Input.GetKey(KeyCode.Space))
		{
            transform.Rotate(new Vector3(0, 0, Time.deltaTime * 10f));
		}
    }
}

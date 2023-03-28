using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody m_Rigidbody;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
       if (Input.GetKeyDown("space"))
        {
            m_Rigidbody.AddForce(new Vector3(Random.Range(-300, 300), 500, 1000));
        }
    }
}

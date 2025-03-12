using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public float speed = 20f;
    public float uppies = 20f;
    public float verticalInput;
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.up * uppies * verticalInput * Time.deltaTime);
    }
}

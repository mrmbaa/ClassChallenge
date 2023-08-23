using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float turnSpeed = 50f;
    private Vector3 sizeIncrease = new Vector3(1f,1f,1f);
    bool isGameStarted = true; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if ((Time.time < 20) && (isGameStarted == true))
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
            transform.Rotate(Vector3.forward, turnSpeed * verticalInput * Time.deltaTime);

            if (Input.GetKey(KeyCode.Space))
            {
                transform.localScale += sizeIncrease * Time.deltaTime;
            }
            else if (gameObject.transform.localScale.x > 1f)
            {
                transform.localScale -= sizeIncrease * Time.deltaTime;
            }
            Debug.Log(Time.time);
        }

        if(Time.time > 20)
        {
            isGameStarted = false;
        }
    }
}

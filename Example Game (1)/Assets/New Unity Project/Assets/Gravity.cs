using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    public float jumpForce = 20;
    public float gravity = -9.81f;
    float velocity;

    void update()
    {
        velocity += gravity * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space)) {
            velocity = jumpForce;
        }

        transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
    }

}

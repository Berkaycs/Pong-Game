using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float verticalInput;
    public string inputID;
    public float speed;


    void Update()
    {
        verticalInput = Input.GetAxis("Vertical" + inputID);

        transform.Translate(Vector2.right * speed * Time.deltaTime * verticalInput);        
    }
}

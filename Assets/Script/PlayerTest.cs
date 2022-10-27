using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    // Start is called before the first frame update
    float moveHorizontal;
    float moveVertical;
    float movespeed = 10f;
    float rotationSpeed = 10f;
    float angle;
    Vector3 targetDirection;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float translation = Input.GetAxis("Vertical") * movespeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
    
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        angle += rotation;
        targetDirection = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));
        transform.Translate(0, 0, translation);

        transform.rotation = Quaternion.LookRotation(targetDirection);



    }
}

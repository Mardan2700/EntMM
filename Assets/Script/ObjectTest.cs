using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectTest : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform myPrefab;


    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(myPrefab, new Vector3(UnityEngine.Random.Range(-5,5),1,UnityEngine.Random.Range(-5,5)), Quaternion.identity);
        }
        

    }
    
    // Update is called once per frame
    void Update()
    {
       
    }
    
    
}

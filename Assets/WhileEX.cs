using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileEX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int counter = 0;

        while(counter < 3){
            Debug.Log("aaaa");
            counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

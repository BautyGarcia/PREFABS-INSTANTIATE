using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectClone;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateCube(){
        int count = 0;

        while (count < 3)
        {
            Instantiate(objectClone);
            
            count++;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        //Debug.Log("This is my count " + count)
        for(int i = 100; i > 0; i--)
        {
            if (i>22)
            {
                Debug.Log("Counting to 100: " + i);

            }
            else
            {
                Debug.Log("This is my count " + i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

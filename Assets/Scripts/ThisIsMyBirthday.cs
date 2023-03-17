using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisIsMyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            
        //Debug.Log("This is my count " + count)
        for(int i = 5; i > 0; i--)
        {
            if (i>4)
            {
                Debug.Log("It is my birthday month! " + i);

            }
            else
            {
                Debug.Log("Month: " + i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

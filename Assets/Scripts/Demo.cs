using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update

    int number1 = 10;
    int number2 = 5;

    int result;
    void Start()
    {
        /*result = number1 + number2;
        number1 = number1 + 10;
        number1 += 10;
        Debug.Log(result);

        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }*/

        if (number1 % 2 == 0)
        {
            Debug.Log(number1 + " is an even number");
        }
        else
        {
            Debug.Log(number1 + " is an odd number");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
      
    }
}

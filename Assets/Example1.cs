using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example1 : MonoBehaviour
{
    [SerializeField]
    private int _points;

    void Start()
    {
        
    }

    
    void Update()
    {
        //if we hit the space key
        //add 10 points

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _points = _points + 10;
            
        }

        if(_points >= 50)
        {
            Debug.Log("You win!");
        }
    }


}//class

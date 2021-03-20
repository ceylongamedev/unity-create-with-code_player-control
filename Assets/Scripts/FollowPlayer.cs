using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    public Vector3 offset = new Vector3(0, 7, -8.5f);

    void Update()
    {
        //camera position =  // player position
        transform.position = player.transform.position + offset;

    }//update


}//class

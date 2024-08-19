using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class pipeMovement : MonoBehaviour
{

    float moveSpeed = 2;
    Transform move;
    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        move.position = move.position + Vector3.left*moveSpeed*Time.deltaTime;
        
    }
}

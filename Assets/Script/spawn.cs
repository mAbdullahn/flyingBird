using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class spawn : MonoBehaviour
{
     [SerializeField]GameObject pipes;
    float timer;
    float spawnrate = 3;
    float spanwPostion = 0;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        spanwPostion = Random.Range(-4, 6);
        transform.position = new UnityEngine.Vector3(transform.position.x, spanwPostion, transform.position.z);
        if (timer < spawnrate)
        {
            timer=timer+Time.deltaTime;
        }
        else
        {
            
            Instantiate(pipes, transform.position, transform.rotation);
            timer = 0;
        }

        
        
    }
}

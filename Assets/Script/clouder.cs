using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class clouder : MonoBehaviour
{
    float spanwPostion;
    float spawnrate = 2f;
    float timer = 0;
    
    [SerializeField]GameObject cloud;
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
            timer = timer + Time.deltaTime;
        }
        else
        {

            Instantiate(
                cloud, transform.position, transform.rotation);
            timer = 0;
        }
    }
}

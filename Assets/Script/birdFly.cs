using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class birdFly : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]AudioSource audio;
    float fly = 5f;
    Rigidbody2D birdbody;
    [SerializeField]public GameObject obj;// for game over
    [SerializeField]GameObject birdone;
    void Start()
    {
        birdbody= GetComponent<Rigidbody2D>();
      

    }

    // Update is called once per frame
    void Update()
    {
        ControllerToFly();
        WindowBoundary();

    }

    private void ControllerToFly()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdbody.velocity = Vector2.up * fly;
            audio.Play();

        }
    }

    private void WindowBoundary()
    {
        if (transform.position.y < -6) // if bird fall down 
        {
            obj.SetActive(true);
            birdone.SetActive(false);
        }
        else if (transform.position.y > 6)
        {
            obj.SetActive(true);
            birdone.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        obj.SetActive(true);
        birdone.SetActive(false);
    }

}

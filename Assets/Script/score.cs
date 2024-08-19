using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    [SerializeField] Text scoreText;
    int point = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text=point.ToString();
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "score")
        {
            point++;
            scoreText.text=point.ToString();
        }
    }
   
}

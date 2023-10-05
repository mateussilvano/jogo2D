using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class saw : MonoBehaviour
{
    public float speed;
    public float moveTime;
    private bool direcao;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        if (direcao)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;
        
        if(timer >= moveTime)
        {
            direcao = !direcao;
            timer = 0f;

        }
    }
}

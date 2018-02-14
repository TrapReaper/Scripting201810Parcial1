using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    [SerializeField]
    private int cube;

    [SerializeField]
    private GameObject cubo;

    private Collider destruction;

    private int die;

    private void Start()
    {
        destruction = GetComponent<Collider>();
        die = 0;

        if(cube == 1)
        {
            Renderer rend = GetComponent<Renderer>();
            
            rend.material.SetColor("_Color", Color.red);
        }
        if(cube == 2)
        {
            Renderer rend = GetComponent<Renderer>();
            
            rend.material.SetColor("_Color", Color.blue);
        }
        if(cube == 3)
        {
            Renderer rend = GetComponent<Renderer>();
            
            rend.material.SetColor("_Color", Color.green);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Ball ball = collision.gameObject.GetComponent<Ball>();

            if (ball != null)
            {
                if(cube == 1)
                {
                    if(die >= 1)
                    {
                        DestroyObject(cubo);
                    }
                    else
                    {
                        die += 1;
                    }
                }

                if (cube == 2)
                {
                    if (die >= 2)
                    {
                        DestroyObject(cubo);
                    }
                    else
                    {
                        die += 1;
                    }
                }

                if (cube == 3)
                {
                    if (die >= 3)
                    {
                        DestroyObject(cubo);
                    }
                    else
                    {
                        die += 1;
                    }
                }
            }

        }
    }


		
}

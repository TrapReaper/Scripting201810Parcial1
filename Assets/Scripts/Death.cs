using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    [SerializeField]
    private GameObject life1;

    [SerializeField]
    private GameObject life2;


    [SerializeField]
    private GameObject life3;

    [SerializeField]
    private Collider death;

    private int life;

    private void Start()
    {
        death = GetComponent<Collider>();
        life = 2;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Ball ball = collision.gameObject.GetComponent<Ball>();

            if (ball != null)
            {
                if(life < 0)
                {
                    Debug.Log("colision0");
                }
                if(life == 2)
                {
                    life -= 1;
                    DestroyObject(life1);
                    Debug.Log("colision1");
                }
                if (life == 1)
                {
                    life -= 1;
                    DestroyObject(life2);
                    Debug.Log("colision2");
                }
                if (life == 0)
                {
                    life -= 1;
                    DestroyObject(life3);
                    Debug.Log("colision3");
                }

            }
        }
    }

                // Update is called once per frame
                void Update () {
		
	}
}

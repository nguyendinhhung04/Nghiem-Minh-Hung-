using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Vector3 A;
    private Vector3 B;

    [SerializeField]
    private float speed = 1.0f;
    private float distance = 5.0f;


    private int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 startPosition = this.transform.position;
        Debug.Log(A);
        Debug.Log(B);
        A = startPosition - new Vector3(distance, 0, 0);
        B = startPosition + new Vector3(distance, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {



        if (direction == 1)
        {
            //Debug.Log("Right");
            //neu direction = 1, di chuyen sang phai
            this.transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));

            if (this.transform.position.x >= B.x)
            {
                direction = -1; //doi chieu sang trai
            }
        }
        else
        {
            //Debug.Log("Left");
            //neu direction = -1, di chuyen sang trai
            this.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            if (this.transform.position.x <= A.x)
            {
                direction = 1; //doi chieu sang phai
            }
        }
    }
}

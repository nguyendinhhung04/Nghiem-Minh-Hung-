using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isMoving = false;
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(6f, 0f, 0f) * Time.deltaTime);
            isMoving = true;
            transform.localScale = new Vector3(1f, 1f, 1f); // Face right
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-6f, 0f, 0f) * Time.deltaTime);
            isMoving = true;
            transform.localScale = new Vector3(-1f, 1f, 1f); // Face left
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0f, 6f, 0f) * Time.deltaTime);
            isMoving = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0f, -6f, 0f) * Time.deltaTime);
            isMoving = true;
        }

        if (isMoving)
        {
            animator.SetBool("isRun", true);
        }
        else
        {
            animator.SetBool("isRun", false);

        }
    }

}

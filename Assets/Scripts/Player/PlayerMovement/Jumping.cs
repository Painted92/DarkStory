using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    private Rigidbody rigidbody;
    [SerializeField] float jumPspeed = 2;
    [SerializeField] LayerMask mask;
    [SerializeField] Transform groundChec;
    private Animator animator;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
   
    public void Jump()// прыжок с системой проверки соприкосновения с землей.
    {
        if (Physics.Raycast(groundChec.position, Vector2.down, 0.2f, mask))
        {
            animator.SetTrigger("Jump");
            rigidbody.AddForce(Vector3.up * jumPspeed, ForceMode.Impulse);
        }
        else
        {
            Debug.Log("Did not find ground layer");
        }
    }
    private void Update()
    {
        if (Physics.Raycast(groundChec.position, Vector2.down, 0.3f, mask))// проверка на соприкосновение с землейю
        {
            animator.SetBool("isinAir", false);
        }
        else
        {
            animator.SetBool("isinAir", true);
        }
    }
}

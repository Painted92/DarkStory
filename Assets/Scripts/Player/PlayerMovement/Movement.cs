using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rigidbody;
    [SerializeField] float speed = 2;
    [SerializeField] float jumPspeed = 2;
    [SerializeField] LayerMask mask;
    [SerializeField] Transform groundChec;
    private Animator animator;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    private void RotationPlayer(float xValue)// �������� ���������, �������� � ����� ������ ���������� ��� ������� ��� Input.GetAxis("Horizontal")) ��� �� ����� ��������� ��� ������������ ������� ����������.
    {
        if (xValue < 0)
             transform.localEulerAngles = new Vector3(0, -90, 0);
        else if (xValue > 0)
             transform.localEulerAngles = new Vector3(0,90, 0);
    }
    public void MoveHorizontal(Joystick joystick) // ������� ������ ��������� � �������� ������ ���������� ������� ��� ���� ������� ����������.
    {
        float h = joystick.Horizontal; // ������ ���������� ��� �������� ��� ���������� ����.
        Vector3 directionVEctor = new Vector3(h, 0, 0);  // �������� ������ ����.                          
        rigidbody.velocity =new Vector3(h * speed, rigidbody.velocity.y, rigidbody.velocity.z); // ������ �������� ����� ����������.
        animator.SetFloat("Speed", Vector3.ClampMagnitude(directionVEctor, 1).magnitude); // ������� ��� ��������� ����� ��������.
        RotationPlayer(joystick.Horizontal);// ����� ������ �������.
    }
    public void Jump()// ������ � �������� �������� ��������������� � ������.
    {
        if(Physics.Raycast(groundChec.position, Vector2.down,0.2f,mask)) 
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
        if (Physics.Raycast(groundChec.position, Vector2.down, 0.3f, mask))// �������� �� ��������������� � �������
        {
            animator.SetBool("isinAir", false);
        }
        else
        {
            animator.SetBool("isinAir", true);
        }
    }
}

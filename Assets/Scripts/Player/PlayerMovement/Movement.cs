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
    private void RotationPlayer(float xValue)// Разворот персонажа, передаем в метод способ управления или джостик или Input.GetAxis("Horizontal")) так же можно применять для вертикальной системы управления.
    {
        if (xValue < 0)
             transform.localEulerAngles = new Vector3(0, -90, 0);
        else if (xValue > 0)
             transform.localEulerAngles = new Vector3(0,90, 0);
    }
    public void MoveHorizontal(Joystick joystick) // система двжния персонажа в аргумент метода передается джостик или иная система управления.
    {
        float h = joystick.Horizontal; // создем переменные для джостика для сокращения кода.
        Vector3 directionVEctor = new Vector3(h, 0, 0);  // избегаем лишних цифр.                          
        rigidbody.velocity =new Vector3(h * speed, rigidbody.velocity.y, rigidbody.velocity.z); // задаем движение через риджитбоди.
        animator.SetFloat("Speed", Vector3.ClampMagnitude(directionVEctor, 1).magnitude); // система для активации древа анимаций.
        RotationPlayer(joystick.Horizontal);// вызов метода ротации.
    }
    public void Jump()// прыжок с системой проверки соприкосновения с землей.
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

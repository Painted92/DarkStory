using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2d : MonoBehaviour
{
    [Header("Parameter")]
    [SerializeField] private Transform playerTransform;
    [SerializeField] private string playerTag;
    [SerializeField] private float playerSpeed;

    private void Awake()
    {
        if(this.playerTransform == null)
        {
            if(this.playerTag == "")
            {
                this.playerTag = "Player";
            }
            this.playerTransform = GameObject.FindGameObjectWithTag(this.playerTag).transform;
        }
        this.transform.position = new Vector3()
        {
            x = this.playerTransform.position.x,
            y = this.playerTransform.position.y + 5,
            z = this.playerTransform.position.z - 30,
        };
           
    }
    private void Update()
    {
        if(this.playerTransform)
        {
            Vector3 target = new Vector3()
            {
                x = this.playerTransform.position.x,
                y = this.playerTransform.position.y +5,
                z = this.playerTransform.position.z - 30,
            };
            Vector3 pos = Vector3.Lerp(this.transform.position, target, this.playerSpeed * Time.deltaTime);

            this.transform.position = pos;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class CameraFollow2d : MonoBehaviour
    {
        [Header("Parameter")]
        [SerializeField] private Transform playerTransform;
        [SerializeField] private string playerTag;
        [SerializeField] private float playerSpeed;
        [SerializeField] private float xValue;
        [SerializeField] private float yValue;
        [SerializeField] private float zValue;

        private void Awake()
        {
            if (this.playerTransform == null)
            {
                if (this.playerTag == "")
                {
                    this.playerTag = "Player";
                }
                this.playerTransform = GameObject.FindGameObjectWithTag(this.playerTag).transform;
            }
            this.transform.position = new Vector3()
            {
                x = this.playerTransform.position.x,
                y = this.playerTransform.position.y + 1.17f,
                z = this.playerTransform.position.z - 13.87f,
            };

        }
        private void Update()
        {
            if (this.playerTransform)
            {
                Vector3 target = new Vector3()
                {
                    x = this.playerTransform.position.x + xValue,
                    y = this.playerTransform.position.y + yValue,
                    z = this.playerTransform.position.z - zValue,
                };
                Vector3 pos = Vector3.Lerp(this.transform.position, target, this.playerSpeed * Time.deltaTime);

                this.transform.position = pos;
            }
        }
    }

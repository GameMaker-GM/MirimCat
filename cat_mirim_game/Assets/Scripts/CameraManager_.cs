using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager_ : MonoBehaviour
{

    public GameObject target;  //카메하가 따라갈 대상
    public float moveSpeed; //카메라가 얼마나 빠른 속도로
    private Vector3 targetPosition;//대사으이 현재 위치 값

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        if (target.gameObject != null)
        {
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime); //Time.deltaTime= 1초에 moveSpeed만큼 이동
        }


    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pyramid : MonoBehaviour
{
    public float minSpeed; //장애물 최소속도
    public float maxSpeed; // 장애물 최대속도
    
    private float obstacleSpeed; // 장애물 현재속도 
    
    // Start is called before the first frame update
    void Start()
    {
        obstacleSpeed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * obstacleSpeed * Time.deltaTime); //장애물을 이동시킴
        //transform.positio += Vector3.left * speed * Time.deltaTime;
       
    }
}

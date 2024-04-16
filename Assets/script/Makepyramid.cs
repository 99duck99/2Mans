using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makescore : MonoBehaviour
{
    public GameObject Scoredesert; // 게임오브젝트 피라미드 지정

    float timer = 0;
    private float TimeDiff; // 장애물 생성시간 지정
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > TimeDiff)
        {
            TimeDiff = Random.Range(1f, 5f); // 장애물 생성시간
            GameObject newScoredesert = Instantiate(Scoredesert); // Instantiate() <-괄호 안에있는 게임오브젝트 생성
            newScoredesert.transform.position = new Vector3(20f, -6.91f, 0); //장애물 생성 위치
             timer = 0; // 재생성시간 초기화
             Destroy(newScoredesert, 25.0f); // 장애물 파괘
        }
        
    }
}

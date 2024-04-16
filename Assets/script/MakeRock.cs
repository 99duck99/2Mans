using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeRock : MonoBehaviour
{
    public GameObject ScoreMountain;

    float timer = 0; // 오브젝트 생성시간

    private float TimeDiff;
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
            GameObject newScoreMountain = Instantiate(ScoreMountain); // Instantiate() <-괄호 안에있는 게임오브젝트 생성
            newScoreMountain.transform.position = new Vector3(20f, -0.2f, 0); //장애물 생성 위치
             timer = 0; // 재생성시간 초기화
             Destroy(newScoreMountain, 25.0f); // 장애물 파괘
        }
    }
}

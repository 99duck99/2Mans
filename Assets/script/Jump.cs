using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb; //Rigidbody 2D값 변수지정

    public float jumpSpeed; //점프속도

    bool isGrounded; //Ground 태그 지정

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Rigidbody 2D 불러오기
    }

    void Update() 
    {
    }
    

    private void OnCollisionEnter2D(Collision2D other) 
    {
       if(other.gameObject.tag == "Ground")
       {
           isGrounded = true;

       }
       if(Score.score > Score.bestscore)
        {
            Score.bestscore = Score.score;
             // 최고 점수 저장
            PlayerPrefs.SetInt("BestScore", Score.bestscore);
            PlayerPrefs.Save();
            
        }
        
        
       // 충돌한 객체가 장애물인지 확인
        if(other.gameObject.tag == "Obstacle")
        {
            // 다른 씬으로 전환
            SceneManager.LoadScene("GameOver");
        }
        

    }

    public void jumpButton()
    {
        if(isGrounded)
        {
            isGrounded = false;
            rb.velocity = Vector2.up * jumpSpeed;
        }
    }

    
    
    
    
    
   private void FixedUpdate() {
        
    }
    
}
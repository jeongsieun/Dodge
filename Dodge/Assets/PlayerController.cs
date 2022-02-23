using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // int a = 3; => 전역변수. class안 method에서 사용가능. 멤버변수 필드라고도 한다.

    // 이동에 사용할 리지드바디 컴포넌트
    public Rigidbody playerRigidbody;  //public 클래스의 내부/외부 모든 곳에서 접근이 가능

    //이동속렬
    public float speed = 8f;


    // Start is called before the first frame update
    void Start()
    {
        // 게임이 시작되면, 가장 먼저 시작되는 method
        // method 안에 선언되어 사용된 변수 지역변수 -> 그 지역에서만 사용 가능하다.
        // method 하나의 기능을 모아놓은 꾸러미
        // 전역변수는 클래스 아래 속함. class아래에 만든다
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자의 방향키를 감지해서 접근
    }

    void sum()
    {

    }
}

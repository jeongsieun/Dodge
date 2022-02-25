using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour //MonoBehaviour를 상속 받았기 때문에 unity inspector view에 할당이 가능한 것
{
    // int a = 3; => 전역변수. class안 method에서 사용가능. 멤버변수 필드라고도 한다.

    // 이동에 사용할 리지드바디 컴포넌트
    public Rigidbody playerRigidbody;

    //이동속력
    public float speed = 8f;

    // 내 자신을 담을 변수
    public GameObject my;


    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아서 playerRigidbody에 할당
        // playerRigidbody = GetComponent<가져와서 담을 데이터 형태>();
        playerRigidbody = GetComponent < Rigidbody > ();

        // method 안에 선언되어 사용된 변수 지역변수 -> 그 지역에서만 사용 가능하다.
        // method 하나의 기능을 모아놓은 꾸러미
        // 전역변수는 클래스 아래 속함. class아래에 만든다
    }


    void Update()
    {
        // 수평축과 수직축의 입력값을 감지해서 저장
        // 어떤 축에 대한 입력값을 숫자로 반환. unity에서 지정된 축의 이름 ->Horizontal 

        float xInput = Input.GetAxis("Horizontal");
        // 키보드 : 'A' , <- : 음의 방향 : 최대값 -1.0f
        // 키보드 : 'D' , -> : 양의 방향 : 최대값 +1.0f
        float zInput = Input.GetAxis("Vertical");
        // 키보드 : 'W', ^   : 양의 방향 : +1.0f
        // 키보드 : 'S',  : 음의 방향 : -1.0f


        // 실제 이동 속도 입력값과 이동 속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;


        // vector3 속도를 (xSpeed, 0f, zSpeed) 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        // 리지드바디의 속도에 newVelocity를 할당
        playerRigidbody.velocity = newVelocity;

    }



    void DirectInput()
    {
        // 사용자의 방향키를 감지해서 접근
        if (Input.GetKey(KeyCode.UpArrow) == true)  // 위쪽 방향키 UpArrow ,(get -> 읽기 , set-> 쓰기 : 사용자가 누르면 불리언 값 반환)
        {
            // playerRigidbody 안의 AddForce 메소드 이용 (x_좌우, y_위아래, z_앞뒤)
            // AddForce : 힘을 주는 기능. 밀면 나아가는 것. x, y, z에 맞는 힘을 주는 것.
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            // 아래쪽 방향키 입력이 감지된 경우. -Z 방향 힘주기
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            // 왼쪽 방향키 입력이 감지된 경우. -X방향 힘주기
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            // 오른쪽 방향키 입력이 감지된 경우 . X 방향 힘주기
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
    }

    // 총알을 맞았을 때, player의 모습을 안보이게 함. 활성/비활성(inspector view에서 plyer의 체크를 해제하면 안보임)
    public void die()
    {
        my.SetActive(false); 
    }

    
    

}

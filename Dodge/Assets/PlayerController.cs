using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour //MonoBehaviour를 상상 받았기 때문에 unity inspector view에 할당이 가능한 것
{
    // int a = 3; => 전역변수. class안 method에서 사용가능. 멤버변수 필드라고도 한다.

    // 이동에 사용할 리지드바디 컴포넌트
    public Rigidbody playerRigidbody;  //public 클래스의 내부/외부 모든 곳에서 접근이 가능

    //이동속렬
    public float speed = 8f; // 개발완료 후에는 PUBLIC 삭제 해줘야 함

    // 내 자신을 담을 변수
    public GameObject my;


    // Start is called before the first frame update
    void Start() // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아서 playerRigidbody에 할당
    {
        playerRigidbody = GetComponent < Rigidbody > ();
        // playerRigidbody = GetComponent<가져와서 담을 데이터 형태>();



        // 게임이 시작되면, 가장 먼저 시작되는 method
        // method 안에 선언되어 사용된 변수 지역변수 -> 그 지역에서만 사용 가능하다.
        // method 하나의 기능을 모아놓은 꾸러미
        // 전역변수는 클래스 아래 속함. class아래에 만든다


    }


    // Update is called once per frame
    void Update()
    {
        // 수펻축과 수직축의 입력값을 감지해서 저장
        // 지정한 축의 방향을 인풋메니저를 통해 받을 수 있다.
        float xInput = Input.GetAxis("Horizonatal"); //수평측과 수직측의 입력값을 받아 저장
        // 어떤 축에 대한 입력값을 숫자로 반환. unity에서 지정된 축의 이름 ->Horizonatal 
        // 키보드 : 'A' , <- : 음의 방향 : 최대값 -1.0f
        // 키보드 : 'D' , -> : 양의 방향 : 최대값 +1.0f
        float zInout = Input.GetAxis("Vertical");
        // 키보드 : 'W', ^   : 양의 방향 : +1.0f
        // 키보드 : 'S',  : 음의 방향 : -1.0f

        // 방법 2
        //DirectInput(); // 한 프레임당 DirectInput 메소드 호출


        // 방법 1
        //// 사용자의 방향키를 감지해서 접근
        //if(Input.GetKey(KeyCode.UpArrow) == true)  // 위쪽 방향키 UpArrow ,(get -> 읽기 , set-> 쓰기 : 사용자가 누르면 불리언 값 반환)
        //{
        //    playerRigidbody.AddForce(0f, 0f, speed); // playerRigidbody 안의 AddForce 메소드 이용 (x_좌우, y_위아래, z_앞뒤)
        //    // AddForce : 힘을 주는 기능. 밀면 나아가는 것. x, y, z에 맞는 힘을 주는 것. 앞으로 8f의 힘으로 나아가라는 것
        //}
        //else if(Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    // 아래쪽 방향키 입력이 감지된 경우. -Z 방향 힘주기
        //    playerRigidbody.AddForce(0f, 0f, -speed);
        //}
        //else if(Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    // 왼쪽 방향키 입력이 감지된 경우. -X방향 힘주기
        //    playerRigidbody.AddForce(-speed, 0f, 0f);
        //}
        //else if(Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    // 오른쪽 방향키 입력이 감지된 경우 . X 방향 힘주기
        //    playerRigidbody.AddForce(speed, 0f, 0f);
        //}
    }



    void DirectInput()
    {
        // 사용자의 방향키를 감지해서 접근
        if (Input.GetKey(KeyCode.UpArrow) == true)  // 위쪽 방향키 UpArrow ,(get -> 읽기 , set-> 쓰기 : 사용자가 누르면 불리언 값 반환)
        {
            playerRigidbody.AddForce(0f, 0f, speed); // playerRigidbody 안의 AddForce 메소드 이용 (x_좌우, y_위아래, z_앞뒤)
            // AddForce : 힘을 주는 기능. 밀면 나아가는 것. x, y, z에 맞는 힘을 주는 것. 앞으로 8f의 힘으로 나아가라는 것
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
    void die()
    {
        //1. 전역변수를 하나 만든다. 껐다가 켤 player. 자료형은 GameObject
        // 
        //2. object를 껐다가 켜거나 부품 component를 껐다 켠다

        my.SetActive(false); // on true  -> my에 () 행동을 보낸다.
        // gameObject.SetActive(false); //내 자신의 오브젝트에 접근하는 건 자주 접근한다. 자주 쓰는 변수는 유니티가 해당기능 제공. 다른 접근법
        // 컴파일러가 알아서 진행
        // GameObject : 데이터타입
        // gameObject : 변수
    }

    
    

}

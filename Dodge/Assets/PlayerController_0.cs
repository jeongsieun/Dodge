using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_0 : MonoBehaviour //MonoBehaviour를 상상 받았기 때문에 unity inspector view에 할당이 가능한 것
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
        playerRigidbody = GetComponent<Rigidbody>();
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
        float xInput = Input.GetAxis("Horizontal"); //수평측과 수직측의 입력값을 받아 저장
        // 어떤 축에 대한 입력값을 숫자로 반환. unity에서 지정된 축의 이름 ->Horizonatal 
        // 키보드 : 'A' , <- : 음의 방향 : 최대값 -1.0f
        // 키보드 : 'D' , -> : 양의 방향 : 최대값 +1.0f
        float zInput = Input.GetAxis("Vertical");
        // 키보드 : 'W', ^   : 양의 방향 : +1.0f
        // 키보드 : 'S',  : 음의 방향 : -1.0f

        // 속력은 정했으니 곱하면 된다.
        // 실제 이동 속도 입력값과 이동 속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;
        // 이동할 방향성에 속도까지 처리해서 실제 이동속도를 구현
        //반영 전 실제 이동 속도를 처리
        // 구한 속도를 반영

        //x, y, z축은 삼원소
        // 게임에서는 벡터 3타입이라고 한다.
        // 게임개발 뿐 아니라 36가지 원소르 ㄹ쓰는 형태에서는 전부 벡터 ㅊ3라고 한다
        // 산술 인공지능 둥 모든 분야에서 3가지 원소 씀
        // 3가지 원소를 하나의 컨테이너에 담는다.
        //두가지 원소를 담으면 벡터 2. z가 빠진다.
        // 4가지 원소는 w추가. 벡터 4라고 표현

        //unity의 벡터 3는 다양하게 이용된다. 포지션 위치. 회전, 스케일, 크기
        // 속력또한 3차원이기 때문에 벡터3로 처리. 2d게임은 벡터 2로 이원소만 이용해 처리
        // 3d 게임이기 때문에 속력에서 3원소 벡터 3를 쓴다.
        // 3가지 원소를 담을 수 있는 데이터 컨테이너 형태
        //변수는 데이터를 담는 박스. 컨테이너는 박스를 무진장 많이 담을 수 ㅣ싿.
        // 이런 데이터 형태를 데이터 컨테이너라고 ㅍ현한다.
        // 이런 벡터3은 3가지 원소만 충족하면 쓸 수 있다.
        // 하나의 원소라도 무시하면 에러남. 0이라도 입력
        // 3가지 원소값을 충족해줘야 한다. 벡터 2는 2가지 원소값
        // 속력을 미리 분할
        //데이터 컨테이너를 통채로 넣어주고, 여기에 속력값을 넣어줌

        // vector3 속도를 (xSpeed, 0f, zSpeed) 생송
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        // 리지드바디의 물리적인 힘X  -> 속도
        // 리지드바디의 속도에 newVelocity를 할당
        playerRigidbody.velocity = newVelocity;

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
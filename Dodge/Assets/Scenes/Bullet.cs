using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 이동에 사용할 리지드바디 컴포넌트
    private Rigidbody bulletRigidbody;
    // 탄알 이동 속력
    public float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 bulletRigidbody에 할당
        bulletRigidbody = GetComponent<Rigidbody>();

        // 리지드바디의 속도 = 앞쪽 방향 * 이동 속력
        bulletRigidbody.velocity = transform.forward * speed;
        // 리지드 바디의 접근은 리지드바디의 벨로시티
        // 그 이전에는 속도 부분을 할당해서 연산
        // 대문자 G로 시작하는 오브젝트 데이터 형태. Transform 데이터 형태
        // 소문자 g는 유니티에서 할당하는 . 내자신의 트랜스폼을 할당
        //. forward

        Destroy(gameObject, 3f);
    }

    // 이 메소드를 만들어서 리지드바디 실행
    // 콜라이더는 충돌만 감지만, 리지드 바디는 충돌했음을 알려줌
    // 리지드 바디가 충돌 정보를 (데이터컨테이너)를 콜라이더로 보냄

    // 트리거 충돌 시 자동으로 실행되는 메소드
    private void OnTriggerEnter(Collider other) // Collider 받아오는 것
    {
        // 충돌한 상대방 게임 오브젝트가 player태그를 가졌나요?
        if(other.tag == "player") // order의 태그값이 있으면, 플레이어의 메세지를 실현한다.
        {
            // 상대방(충돌한) 게임 오브젝트에서 playerController 컴포넌트 가져오기
            // 모노비헤이비어 상속받음. 오브젝트에 할당하는 순간 컴포넌트(부품화)
            PlayerController playerController = other.GetComponent<PlayerController>();

            // 상대방으로부터 PlayerController 컴포넌트를 가져오는데 성공했다면
            // 값이 없으면, null에러가 뜸. 그 에러를 막기 위해 성공했는지 않했는지 확인
            if(playerController != null)
            {
                // playerController 컴포넌트의 Die() 메서드 실행
                playerController.die();
            }
        }
        // 온라인에서는 네트워크 패키지에 따라 메세지 처리. your controller. 플레이어 컨트롤러가 들어있지 않을 수 있다.
        
    }
    
    
    //리지드 바이듸 접근은 리지드바디의 벨로시티=
    // 그 이전에는 속도 부분을 할당해서 연산
    // 대문자 G로 시작하는 오브젝트 데이터 형태. Transform 데이터 형태
    // 소문자 g는 유니티에서 할당하는 . 내자신의 트랜스폼을 할당
    //. forward

    // Update is called once per frame
    void Update()
    {
        
    }
}

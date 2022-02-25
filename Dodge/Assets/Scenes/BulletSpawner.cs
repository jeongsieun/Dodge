using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // 생성할 탄알의 원본 프리팹
    public GameObject bullerPrefab;

    // 최소 생성 주기
    public float spawnRateMin = 0.5f;
    // 최대 생성 주기
    public float spawnRateMax = 3f;

    // 실제 생성 주기
    private float spawnRate; // 위에서 랜덤하게 뽑아 생성해야 하므로 우선 선언만

    // 최근 생성 시점에서 지난 시간
    private float timeAfterSpawn; // 0초부터 시작해 시간 누적. 발사 후 초기화 해 재 누적

    // 발사할 대상 . 플레이어의 위치 필요
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        // 최근 생성 이후의 누적 시간을 0으로 초기화
        timeAfterSpawn = 0; // 0은 f를 넣지 않아도 됨
        // 탄알 생성 간격을 spawnRateMin과 spawnRateMax 사이에서 랜덤 값 지정해 spawnRate에 할당
        // 유니티에서 랜던한 값 추출하기
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        // random unity 에서 주어지는 클래스

        // PlayerController 컴포넌트를 가진 게임 오브젝트를 찾아서 그 오브젝트의 위치값을 가져와
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame

    // 실시간 발사되어야 하므로 업데이트에서 구현
    void Update()
    {
        //총알을 가져온 원본 프리팹을 복제 생성

        //파괴는 디스토리
        //생성은 
        Instantiate(bullerPrefab);
    }
}

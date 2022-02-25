using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // ������ ź���� ���� ������
    public GameObject bullerPrefab;

    // �ּ� ���� �ֱ�
    public float spawnRateMin = 0.5f;
    // �ִ� ���� �ֱ�
    public float spawnRateMax = 3f;

    // ���� ���� �ֱ�
    private float spawnRate; // ������ �����ϰ� �̾� �����ؾ� �ϹǷ� �켱 ����

    // �ֱ� ���� �������� ���� �ð�
    private float timeAfterSpawn; // 0�ʺ��� ������ �ð� ����. �߻� �� �ʱ�ȭ �� �� ����

    // �߻��� ��� . �÷��̾��� ��ġ �ʿ�
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        // �ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0; // 0�� f�� ���� �ʾƵ� ��
        // ź�� ���� ������ spawnRateMin�� spawnRateMax ���̿��� ���� �� ������ spawnRate�� �Ҵ�
        // ����Ƽ���� ������ �� �����ϱ�
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        // random unity ���� �־����� Ŭ����

        // PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� ������
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame

    // �ǽð� �߻�Ǿ�� �ϹǷ� ������Ʈ���� ����
    void Update()
    {
        //�Ѿ��� ������ ���� �������� ���� ����

        //�ı��� ���丮
        //������ 
        Instantiate(bullerPrefab);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // �̵��� ����� ������ٵ� ������Ʈ
    private Rigidbody bulletRigidbody;
    // ź�� �̵� �ӷ�
    public float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();

        // ������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;
        // ������ �ٵ��� ������ ������ٵ��� ���ν�Ƽ
        // �� �������� �ӵ� �κ��� �Ҵ��ؼ� ����
        // �빮�� G�� �����ϴ� ������Ʈ ������ ����. Transform ������ ����
        // �ҹ��� g�� ����Ƽ���� �Ҵ��ϴ� . ���ڽ��� Ʈ�������� �Ҵ�
        //. forward

        Destroy(gameObject, 3f);
    }

    // �� �޼ҵ带 ���� ������ٵ� ����
    // �ݶ��̴��� �浹�� ������, ������ �ٵ�� �浹������ �˷���
    // ������ �ٵ� �浹 ������ (�����������̳�)�� �ݶ��̴��� ����

    // Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼ҵ�
    private void OnTriggerEnter(Collider other) // Collider �޾ƿ��� ��
    {
        // �浹�� ���� ���� ������Ʈ�� player�±׸� ��������?
        if(other.tag == "player") // order�� �±װ��� ������, �÷��̾��� �޼����� �����Ѵ�.
        {
            // ����(�浹��) ���� ������Ʈ���� playerController ������Ʈ ��������
            // �������̺�� ��ӹ���. ������Ʈ�� �Ҵ��ϴ� ���� ������Ʈ(��ǰȭ)
            PlayerController playerController = other.GetComponent<PlayerController>();

            // �������κ��� PlayerController ������Ʈ�� �������µ� �����ߴٸ�
            // ���� ������, null������ ��. �� ������ ���� ���� �����ߴ��� ���ߴ��� Ȯ��
            if(playerController != null)
            {
                // playerController ������Ʈ�� Die() �޼��� ����
                playerController.die();
            }
        }
        // �¶��ο����� ��Ʈ��ũ ��Ű���� ���� �޼��� ó��. your controller. �÷��̾� ��Ʈ�ѷ��� ������� ���� �� �ִ�.
        
    }
    
    
    //������ ���̵� ������ ������ٵ��� ���ν�Ƽ=
    // �� �������� �ӵ� �κ��� �Ҵ��ؼ� ����
    // �빮�� G�� �����ϴ� ������Ʈ ������ ����. Transform ������ ����
    // �ҹ��� g�� ����Ƽ���� �Ҵ��ϴ� . ���ڽ��� Ʈ�������� �Ҵ�
    //. forward

    // Update is called once per frame
    void Update()
    {
        
    }
}

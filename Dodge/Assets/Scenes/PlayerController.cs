using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour //MonoBehaviour�� ��� �޾ұ� ������ unity inspector view�� �Ҵ��� ������ ��
{
    // int a = 3; => ��������. class�� method���� ��밡��. ������� �ʵ��� �Ѵ�.

    // �̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;

    //�̵��ӷ�
    public float speed = 8f;

    // �� �ڽ��� ���� ����
    public GameObject my;


    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�Ƽ� playerRigidbody�� �Ҵ�
        // playerRigidbody = GetComponent<�����ͼ� ���� ������ ����>();
        playerRigidbody = GetComponent < Rigidbody > ();

        // method �ȿ� ����Ǿ� ���� ���� �������� -> �� ���������� ��� �����ϴ�.
        // method �ϳ��� ����� ��Ƴ��� �ٷ���
        // ���������� Ŭ���� �Ʒ� ����. class�Ʒ��� �����
    }


    void Update()
    {
        // ������� �������� �Է°��� �����ؼ� ����
        // � �࿡ ���� �Է°��� ���ڷ� ��ȯ. unity���� ������ ���� �̸� ->Horizontal 

        float xInput = Input.GetAxis("Horizontal");
        // Ű���� : 'A' , <- : ���� ���� : �ִ밪 -1.0f
        // Ű���� : 'D' , -> : ���� ���� : �ִ밪 +1.0f
        float zInput = Input.GetAxis("Vertical");
        // Ű���� : 'W', ^   : ���� ���� : +1.0f
        // Ű���� : 'S',  : ���� ���� : -1.0f


        // ���� �̵� �ӵ� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;


        // vector3 �ӵ��� (xSpeed, 0f, zSpeed) ����
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        // ������ٵ��� �ӵ��� newVelocity�� �Ҵ�
        playerRigidbody.velocity = newVelocity;

    }



    void DirectInput()
    {
        // ������� ����Ű�� �����ؼ� ����
        if (Input.GetKey(KeyCode.UpArrow) == true)  // ���� ����Ű UpArrow ,(get -> �б� , set-> ���� : ����ڰ� ������ �Ҹ��� �� ��ȯ)
        {
            // playerRigidbody ���� AddForce �޼ҵ� �̿� (x_�¿�, y_���Ʒ�, z_�յ�)
            // AddForce : ���� �ִ� ���. �и� ���ư��� ��. x, y, z�� �´� ���� �ִ� ��.
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            // �Ʒ��� ����Ű �Է��� ������ ���. -Z ���� ���ֱ�
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            // ���� ����Ű �Է��� ������ ���. -X���� ���ֱ�
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            // ������ ����Ű �Է��� ������ ��� . X ���� ���ֱ�
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
    }

    // �Ѿ��� �¾��� ��, player�� ����� �Ⱥ��̰� ��. Ȱ��/��Ȱ��(inspector view���� plyer�� üũ�� �����ϸ� �Ⱥ���)
    public void die()
    {
        my.SetActive(false); 
    }

    
    

}

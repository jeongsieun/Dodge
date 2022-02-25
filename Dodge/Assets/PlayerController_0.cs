using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_0 : MonoBehaviour //MonoBehaviour�� ��� �޾ұ� ������ unity inspector view�� �Ҵ��� ������ ��
{
    // int a = 3; => ��������. class�� method���� ��밡��. ������� �ʵ��� �Ѵ�.

    // �̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;  //public Ŭ������ ����/�ܺ� ��� ������ ������ ����

    //�̵��ӷ�
    public float speed = 8f; // ���߿Ϸ� �Ŀ��� PUBLIC ���� ����� ��

    // �� �ڽ��� ���� ����
    public GameObject my;


    // Start is called before the first frame update
    void Start() // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�Ƽ� playerRigidbody�� �Ҵ�
    {
        playerRigidbody = GetComponent<Rigidbody>();
        // playerRigidbody = GetComponent<�����ͼ� ���� ������ ����>();



        // ������ ���۵Ǹ�, ���� ���� ���۵Ǵ� method
        // method �ȿ� ����Ǿ� ���� ���� �������� -> �� ���������� ��� �����ϴ�.
        // method �ϳ��� ����� ��Ƴ��� �ٷ���
        // ���������� Ŭ���� �Ʒ� ����. class�Ʒ��� �����


    }


    // Update is called once per frame
    void Update()
    {
        // ������� �������� �Է°��� �����ؼ� ����
        // ������ ���� ������ ��ǲ�޴����� ���� ���� �� �ִ�.
        float xInput = Input.GetAxis("Horizontal"); //�������� �������� �Է°��� �޾� ����
        // � �࿡ ���� �Է°��� ���ڷ� ��ȯ. unity���� ������ ���� �̸� ->Horizonatal 
        // Ű���� : 'A' , <- : ���� ���� : �ִ밪 -1.0f
        // Ű���� : 'D' , -> : ���� ���� : �ִ밪 +1.0f
        float zInput = Input.GetAxis("Vertical");
        // Ű���� : 'W', ^   : ���� ���� : +1.0f
        // Ű���� : 'S',  : ���� ���� : -1.0f

        // �ӷ��� �������� ���ϸ� �ȴ�.
        // ���� �̵� �ӵ� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;
        // �̵��� ���⼺�� �ӵ����� ó���ؼ� ���� �̵��ӵ��� ����
        //�ݿ� �� ���� �̵� �ӵ��� ó��
        // ���� �ӵ��� �ݿ�

        //x, y, z���� �����
        // ���ӿ����� ���� 3Ÿ���̶�� �Ѵ�.
        // ���Ӱ��� �� �ƴ϶� 36���� ���Ҹ� ������ ���¿����� ���� ���� ��3��� �Ѵ�
        // ��� �ΰ����� �� ��� �о߿��� 3���� ���� ��
        // 3���� ���Ҹ� �ϳ��� �����̳ʿ� ��´�.
        //�ΰ��� ���Ҹ� ������ ���� 2. z�� ������.
        // 4���� ���Ҵ� w�߰�. ���� 4��� ǥ��

        //unity�� ���� 3�� �پ��ϰ� �̿�ȴ�. ������ ��ġ. ȸ��, ������, ũ��
        // �ӷ¶��� 3�����̱� ������ ����3�� ó��. 2d������ ���� 2�� �̿��Ҹ� �̿��� ó��
        // 3d �����̱� ������ �ӷ¿��� 3���� ���� 3�� ����.
        // 3���� ���Ҹ� ���� �� �ִ� ������ �����̳� ����
        //������ �����͸� ��� �ڽ�. �����̳ʴ� �ڽ��� ������ ���� ���� �� �Ӛ�.
        // �̷� ������ ���¸� ������ �����̳ʶ�� �����Ѵ�.
        // �̷� ����3�� 3���� ���Ҹ� �����ϸ� �� �� �ִ�.
        // �ϳ��� ���Ҷ� �����ϸ� ������. 0�̶� �Է�
        // 3���� ���Ұ��� ��������� �Ѵ�. ���� 2�� 2���� ���Ұ�
        // �ӷ��� �̸� ����
        //������ �����̳ʸ� ��ä�� �־��ְ�, ���⿡ �ӷ°��� �־���

        // vector3 �ӵ��� (xSpeed, 0f, zSpeed) ����
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        // ������ٵ��� �������� ��X  -> �ӵ�
        // ������ٵ��� �ӵ��� newVelocity�� �Ҵ�
        playerRigidbody.velocity = newVelocity;

        // ��� 2
        //DirectInput(); // �� �����Ӵ� DirectInput �޼ҵ� ȣ��


        // ��� 1
        //// ������� ����Ű�� �����ؼ� ����
        //if(Input.GetKey(KeyCode.UpArrow) == true)  // ���� ����Ű UpArrow ,(get -> �б� , set-> ���� : ����ڰ� ������ �Ҹ��� �� ��ȯ)
        //{
        //    playerRigidbody.AddForce(0f, 0f, speed); // playerRigidbody ���� AddForce �޼ҵ� �̿� (x_�¿�, y_���Ʒ�, z_�յ�)
        //    // AddForce : ���� �ִ� ���. �и� ���ư��� ��. x, y, z�� �´� ���� �ִ� ��. ������ 8f�� ������ ���ư���� ��
        //}
        //else if(Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    // �Ʒ��� ����Ű �Է��� ������ ���. -Z ���� ���ֱ�
        //    playerRigidbody.AddForce(0f, 0f, -speed);
        //}
        //else if(Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    // ���� ����Ű �Է��� ������ ���. -X���� ���ֱ�
        //    playerRigidbody.AddForce(-speed, 0f, 0f);
        //}
        //else if(Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    // ������ ����Ű �Է��� ������ ��� . X ���� ���ֱ�
        //    playerRigidbody.AddForce(speed, 0f, 0f);
        //}
    }



    void DirectInput()
    {
        // ������� ����Ű�� �����ؼ� ����
        if (Input.GetKey(KeyCode.UpArrow) == true)  // ���� ����Ű UpArrow ,(get -> �б� , set-> ���� : ����ڰ� ������ �Ҹ��� �� ��ȯ)
        {
            playerRigidbody.AddForce(0f, 0f, speed); // playerRigidbody ���� AddForce �޼ҵ� �̿� (x_�¿�, y_���Ʒ�, z_�յ�)
            // AddForce : ���� �ִ� ���. �и� ���ư��� ��. x, y, z�� �´� ���� �ִ� ��. ������ 8f�� ������ ���ư���� ��
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
    void die()
    {
        //1. ���������� �ϳ� �����. ���ٰ� �� player. �ڷ����� GameObject
        // 
        //2. object�� ���ٰ� �Ѱų� ��ǰ component�� ���� �Ҵ�

        my.SetActive(false); // on true  -> my�� () �ൿ�� ������.
        // gameObject.SetActive(false); //�� �ڽ��� ������Ʈ�� �����ϴ� �� ���� �����Ѵ�. ���� ���� ������ ����Ƽ�� �ش��� ����. �ٸ� ���ٹ�
        // �����Ϸ��� �˾Ƽ� ����
        // GameObject : ������Ÿ��
        // gameObject : ����
    }




}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour //MonoBehaviour�� ��� �޾ұ� ������ unity inspector view�� �Ҵ��� ������ ��
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
        playerRigidbody = GetComponent < Rigidbody > ();
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
        float xInput = Input.GetAxis("Horizonatal"); //�������� �������� �Է°��� �޾� ����
        // � �࿡ ���� �Է°��� ���ڷ� ��ȯ. unity���� ������ ���� �̸� ->Horizonatal 
        // Ű���� : 'A' , <- : ���� ���� : �ִ밪 -1.0f
        // Ű���� : 'D' , -> : ���� ���� : �ִ밪 +1.0f
        float zInout = Input.GetAxis("Vertical");
        // Ű���� : 'W', ^   : ���� ���� : +1.0f
        // Ű���� : 'S',  : ���� ���� : -1.0f

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

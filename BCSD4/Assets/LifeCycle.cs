using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    /*
    //6������
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    void OnEnable()
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�");
    }
    // Update is called once per frame
    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    void FixedUpdate()
    {
        Debug.Log("�̵�~");
    }

    void Update()
    {
        Debug.Log("���� ���!!");
    }
    void LateUpdate()
    {
        Debug.Log("����ġ ȹ��.");
    }

    void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }

    void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }
    */
    /*
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        /*
        // Ű �Է�
        if (Input.anyKey)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("�������� �����Ͽ����ϴ�.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵� ��");

        if(Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("������ �̵��� ���߾����ϴ�.");

        if(Input.GetMouseButtonDown(0))
            Debug.Log("�̻��� �߻�!");

        if(Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ ��...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!!");
        
        if (Input.GetButtonDown("Jump"))
            Debug.Log("����!");
        if (Input.GetButton("Jump"))
            Debug.Log("���� ������ ��...");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!!");
        
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��..." + Input.GetAxisRaw("Vertical"));
        }
    }
    */
    
    void Start()
    {
        /*
        int number = 4;

        Vector3 vec = new Vector3(5,5,5);

        transform.Translate(vec);
        */
    }
    void Update()
    {
        /*
        Vector3 vec = new Vector3(0, 0.1f, 0);

        transform.Translate(vec);
        
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(vec);
        */
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal")*Time.deltaTime, Input.GetAxisRaw("Vertical")* Time.deltaTime, 0);
        transform.Translate(vec);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.velocity = new Vector3(2, 4, 3);
        //rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rigid.velocity = Vector3.forward; //1.�ӷ� �ٲٱ�
        //2.�����ϱ�
        
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
            //Debug.Log(rigid.velocity);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);
        
        //3.ȸ����
        //rigid.AddTorque(Vector3.up);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Cube")
            rigid.AddForce(Vector3.up*2, ForceMode.Impulse);
    }
    public void Jump()
    {
        rigid.AddForce(Vector3.up*10,ForceMode.Impulse);
    }
}

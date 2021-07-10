using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;

    float move_y = 0f;
    float move_x = 0f;
    Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        KeyManager.Instance.KeyAction -= OnKeyInput;
        KeyManager.Instance.KeyAction += OnKeyInput;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnKeyInput()
    {        
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }
}

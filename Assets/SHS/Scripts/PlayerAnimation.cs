using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator _animator;

    float move_y = 0f;
    float move_x = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move_x = Input.GetAxis("Horizontal");
        move_y = Input.GetAxis("Vertical");

        _animator.SetFloat("MoveX", move_x);
        _animator.SetFloat("MoveY", move_y);
    }
}

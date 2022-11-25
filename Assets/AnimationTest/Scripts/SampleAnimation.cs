using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleAnimation : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        var isRotation = !Input.GetKey(KeyCode.Space);
        _animator.SetBool("isRotation", isRotation);
    }
}

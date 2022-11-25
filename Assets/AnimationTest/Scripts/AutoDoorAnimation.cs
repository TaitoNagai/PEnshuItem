using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoorAnimation : MonoBehaviour
{
    private Animator _AutoDoor;

    void Start()
    {
        _AutoDoor = GetComponent<Animator>();
    }

    private void Update()
    {
        var auto = !Input.GetKey(KeyCode.Space);
        _AutoDoor.SetBool("isDoor", auto);
    }
}

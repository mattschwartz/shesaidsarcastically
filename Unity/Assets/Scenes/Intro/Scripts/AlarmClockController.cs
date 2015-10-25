using UnityEngine;
using System.Collections;

public class AlarmClockController : MonoBehaviour
{
    public float WaitFor;

    private float _start;
    private Animator _animator;

    // Use this for initialization
    void Start()
    {
        _start = Time.fixedTime;
        _animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (Time.fixedTime >= _start + WaitFor) {
            _animator.SetBool("SetAlarm", true);
        }
    }
}

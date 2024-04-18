using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // 1
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    // 2
    private float _vInput;
    private float _hInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 3
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        // 4
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
        // 5 Vector3F Supplies the direction + speed for capsule to move forward/back on z-axis at the speed calculated. Deltatime for smooth values run in update instead of up to the device frame rate
        this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);
        // 6 Gives the left/right rotation axis 
        this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);
    }
}

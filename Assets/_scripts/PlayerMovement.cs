using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * _speed; // -1 a 1
        float y = Input.GetAxisRaw("Vertical") * Time.deltaTime * _speed; // -1 a 1

        // Vector3 (x, y, z)
        this.transform.position = this.transform.position +
        x * Vector3.right + // Vector3(1, 0, 0)
        y * Vector3.up; // Vector3(0, 1, 0)

    }
}

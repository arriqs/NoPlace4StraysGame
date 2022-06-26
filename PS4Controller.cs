using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PS4Controller : MonoBehaviour
{
    private GameObject cube = null;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Gamepad.all.Count; i++)
        {
            Debug.Log(Gamepad.all[i].name);
        }

        cube = GameObject.Find("PlayerArmature");
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamepad.all.Count > 0)
        {
            if (Gamepad.all[0].leftStick.left.isPressed)
            {
                cube.transform.position += Vector3.left * Time.deltaTime * 5f;
            }
        }
    }
}

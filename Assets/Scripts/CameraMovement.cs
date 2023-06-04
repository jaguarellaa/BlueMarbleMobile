using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Character Character;
    public float MinXPos, MaxXPos;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position=new Vector3(Mathf.Clamp(Character.transform.position.x,MinXPos,MaxXPos),transform.position.y,transform.position.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DTrack;

public class MovePlayer : MonoBehaviour
{
    public DTrack.DTrackReceiverFlystick flystick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = this.transform.position;
        currentPosition.z += flystick.controller2 * 0.1f;
        float forwardDelta = flystick.controller2 * 0.1f;
        float rotationDelta = flystick.controller1 * 0.1f;
        //currentPosition = this.transform.position;
        Debug.Log(forwardDelta);
        this.transform.Translate(Vector3.forward * forwardDelta, Space.Self);
        this.transform.Rotate(Vector3.up, rotationDelta);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalLight : MonoBehaviour
{
    public Goal goal;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (goal.TestIfAllGreen()){
            Vector3 goalPosition;
            goalPosition.x= 0;
            goalPosition.y= 0;
            goalPosition.z= 0;
            transform.position = goalPosition;
        }
        else{
            Vector3 goalPosition;
            goalPosition.x= 0;
            goalPosition.y= -10;
            goalPosition.z= 0;
            transform.position = goalPosition;
        }
    }
}

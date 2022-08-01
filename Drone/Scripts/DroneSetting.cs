using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;

public class DroneSetting : MonoBehaviour
{
    public GameObject DroneAgent;
    public GameObject Goal;

    Vector3 areaInitPos;
    Vector3 droneInitPos;
    Quaternion droneInitRot;

    EnvironmentParameters m_ResetParams;

    private Transform AreaTrans;
    private Transform DroneTrans;
    private Transform GoalTrans;

    private Rigidbody DroneAgent_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(m_ResetParams);

        AreaTrans = gameObject.transform;
        DroneTrans = DroneAgent.transform;
        GoalTrans = Goal.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

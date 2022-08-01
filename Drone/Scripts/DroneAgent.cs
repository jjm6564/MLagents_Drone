using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using PA_DronePack;

public class DroneAgent : Agent
{
    private PA_DroneController dcoScript;

    public DroneSetting area;
    public GameObject goal;
    float preDist;

    private Transform agentTrans;
    private Transform goalTrans;

    private Rigidbody agent_Rigidbody;
    public override void Initialize()
    {
        dcoScript = gameObject.GetComponent<PA_DroneController>();

        agentTrans = gameObject.transform;
        goalTrans = gameObject.transform;

        agent_Rigidbody = gameObject.GetComponent<Rigidbody>();
    }
}

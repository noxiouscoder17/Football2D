using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedGoalScript : MonoBehaviour
{
    public Player reset;
    public Transform football;
    public Rigidbody footballBody;
    public int BlueScore = 0;
    public Text BlueTeam;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (BlueTeam != null)
            BlueTeam.text = ("Blue Team: " + (BlueScore));
    }
    public void OnCollisionEnter(Collision collision)
    {
        BlueScore = BlueScore+1;
        reset.Reset();
    }
}

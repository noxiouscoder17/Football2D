using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueGoalScript : MonoBehaviour
{
    public Player reset;
    public Transform football;
    public Rigidbody footballBody;
    public int RedScore = 0;
    public Text RedTeam;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (RedTeam != null)
            RedTeam.text = ("Red Team: " + (RedScore));
    }
    public void OnCollisionEnter(Collision collision)
    {
        RedScore = RedScore + 1;
        reset.Reset();
    }
}

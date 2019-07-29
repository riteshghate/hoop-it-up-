using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent<Basketball> () != null)
        {

        }
    }
}

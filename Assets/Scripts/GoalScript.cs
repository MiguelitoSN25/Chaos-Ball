using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool IsSolved = false;

    private void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            IsSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collidedWith);
        }
    }
}

using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public float speed;

    private Vector3 dir;

	// Use this for initialization
	void Start () {
        dir = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if (dir == Vector3.forward)
            {
                dir = Vector3.left;
            }
            else
            {
                dir = Vector3.forward;
            }
        }

        MouveBall();
    }

    void MouveBall()
    {
        float amountToMove = speed * Time.deltaTime;
        transform.Translate(dir * amountToMove);
        
    }
}

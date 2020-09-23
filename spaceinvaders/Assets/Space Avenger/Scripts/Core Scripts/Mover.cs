using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// © Glitch Squirrel Design 2017
// All right reserved.

public class Mover : MonoBehaviour {

	[Header("Move ")]
    public Rigidbody2D objectToMove;
	public bool moveable;
    public Vector3 point01;
    public Vector3 point02;
    public float speed;
    public float direction = 1;

    void FixedUpdate()
	{
        Horizontal();
	}

    void Horizontal()
    {
		if (moveable == true)
		{
            objectToMove.AddForce(Vector2.right * speed * direction);

            if (objectToMove.transform.position.x >= point01.x)
			{
				direction = -1;
			}

            if (objectToMove.transform.position.x <= point02.x)
			{
				direction = 1;
			}
		}
    }
}

// © Glitch Squirrel Design 2017
// All right reserved.
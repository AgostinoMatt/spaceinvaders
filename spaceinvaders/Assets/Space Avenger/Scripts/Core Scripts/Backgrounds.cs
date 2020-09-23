using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// © Glitch Squirrel Design 2017
// All right reserved.

public class Backgrounds : MonoBehaviour {

    [Header("Renderers")]
    public MeshRenderer space;
    public MeshRenderer asteroids;
    public MeshRenderer details;

    [Header("Movement")]
    public float spaceSpeed;
    public float spaceSideSpeedFactor;
    public float asteroidsSpeed;
    public float asteroidsSideSpeedFactor;
	public float detailsSpeed;
	public float detailsSideSpeedFactor;

    public Rigidbody2D target;

    private void FixedUpdate()
    {
        if(target == null)
        {
            return;    
        }

        SpaceScrolling();
        AsteroidsScrolling();
        DetailsScrolling();
    }

    private void SpaceScrolling()
    {
        space.material.mainTextureOffset += new Vector2(target.velocity.x * -0.001f * spaceSideSpeedFactor, spaceSpeed * -0.1f * Time.fixedDeltaTime);
    }

    private void AsteroidsScrolling()
    {
        asteroids.material.mainTextureOffset += new Vector2(target.velocity.x * -0.001f * asteroidsSideSpeedFactor, asteroidsSpeed * -0.1f * Time.fixedDeltaTime);
    }

	private void DetailsScrolling()
	{
        details.material.mainTextureOffset += new Vector2(target.velocity.x * -0.001f * detailsSideSpeedFactor, detailsSpeed * -0.1f * Time.fixedDeltaTime);
	}
}

// © Glitch Squirrel Design 2017
// All right reserved.

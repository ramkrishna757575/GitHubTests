using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

	public float rotationSpeed = 1;
	public RotationDirection rotationDirection;
	public enum RotationDirection{X,Y,Z,NegX,NegY,NegZ};

	private float X = 0,Y = 0,Z = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(rotationDirection == RotationDirection.X){
			X = rotationSpeed;
		}else if(rotationDirection == RotationDirection.Y){
			Y = rotationSpeed;
		}else if(rotationDirection == RotationDirection.Z){
			Z = rotationSpeed;
		}else if(rotationDirection == RotationDirection.NegX){
			X = -rotationSpeed;
		}else if(rotationDirection == RotationDirection.NegY){
			Y = -rotationSpeed;
		}else if(rotationDirection == RotationDirection.NegZ){
			Z = -rotationSpeed;
		}
		transform.Rotate(X,Y,Z);
	}
}

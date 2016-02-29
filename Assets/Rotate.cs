using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	void Update () {
        transform.Rotate(transform.InverseTransformDirection(0, 1, 0), 2.4f);
	}
}

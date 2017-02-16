extern alias ClassLibrary1;
extern alias ClassLibrary2;

using UnityEngine;
using System.Collections;

public class TestBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(ClassLibrary1.ClassLibrary.LibraryClass.GetValue());
        Debug.Log(ClassLibrary2.ClassLibrary.LibraryClass.GetValue());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

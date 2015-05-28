using UnityEngine;
using System.Collections;

namespace ProceduralToolkit.Examples.Primitives
{
	[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
	public class Streetlamps : MonoBehaviour 
	{
		//lamp var
		public float lampRadius = .25f;
		public int segments = 12;
		public float lampHeight = 5f;

		public GameObject road;

		//lamp positions and value
		public float lampPositionValue;
		public Vector3 lampPosition1;
		public Vector3 lampPosition2;

		// Use this for initialization
		void awake () 
		{
			lampPosition1 = new Vector3 (0, lampPositionValue, 0);
			lampPosition2 = new Vector3 (0, -lampPositionValue, 0);
		}

		void Start()
		{
			//create two prisms at both lampPositions


		}

	}
}

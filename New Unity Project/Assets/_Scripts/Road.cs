using UnityEngine;
using System.Collections;

//using ProceduralToolkit namespace so that I can call the "MeshE" command
namespace ProceduralToolkit.Examples.Primitives
{
	[RequireComponent(typeof(MeshRenderer))]
	public class Road : MonoBehaviour 
	{
		//road width/length
		public float roadWidthX = 1f;
		public float roadLengthZ = 1f;

		public int xSegments = 10;
		public int zSegments = 10;

		void Start()
		{
			/*
			 * Create a plane with the road width and length values
			 * and number of x and z segments using the procedural toolkit.
			 */
			GetComponent<MeshFilter>().mesh = MeshE.Plane (roadWidthX, roadLengthZ, xSegments, zSegments);
		}

	}
}

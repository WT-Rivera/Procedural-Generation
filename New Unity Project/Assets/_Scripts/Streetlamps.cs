using UnityEngine;
using System.Collections;

namespace ProceduralToolkit.Examples.Primitives
{
    [System.Serializable]
	[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
	public class Streetlamps : MonoBehaviour 
	{
		//lamp var
		public float lampRadius;
		public int segments;
		public float lampHeight;

		public GameObject road;

		//lamp positions and value
		public float lampPositionX;
		private Vector3 lampPosition1;
		private Vector3 lampPosition2;

		void Awake () 
		{
            // on awake, create two Vector3 values for two separate lamps
			lampPosition1 = new Vector3 (lampPositionX, road.transform.position.y, road.transform.position.z);
			lampPosition2 = new Vector3 (-lampPositionX, road.transform.position.y, road.transform.position.z);
		}

		void Start()
		{
            //create two prisms at both lampPositions and at road position
            GetComponent<MeshFilter>().mesh = MeshE.Prism(lampRadius, segments, lampHeight);
		}

	}
}

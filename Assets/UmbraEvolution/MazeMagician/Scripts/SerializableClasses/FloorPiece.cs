//Name: Robert MacGillivray
//File: FloorPiece.cs
//Date: Apr.20.2017
//Purpose: To hold information about 3D floor pieces

//Last Updated: Apr.20.2017 by Robert MacGillivray

using UnityEngine;

namespace UmbraEvolution
{
    [System.Serializable]
    public class FloorPiece
    {
        public GameObject floorPrefab;
        public float floorThickness;

        public FloorPiece(GameObject floorPrefab, float floorThickness)
        {
            this.floorPrefab = floorPrefab;
            this.floorThickness = floorThickness;
        }
    }
}

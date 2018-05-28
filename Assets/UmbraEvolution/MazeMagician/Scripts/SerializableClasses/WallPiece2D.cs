//Name: Robert MacGillivray
//File: WallPiece2D.cs
//Date: Apr.20.2017
//Purpose: To hold information about 2D wall pieces

//Last Updated: Apr.20.2017 by Robert MacGillivray

using UnityEngine;

namespace UmbraEvolution
{
    [System.Serializable]
    public class WallPiece2D
    {
        public GameObject wallPrefab;
        public float wallZPlane;

        public WallPiece2D(GameObject wallPrefab, float wallZPlane)
        {
            this.wallPrefab = wallPrefab;
            this.wallZPlane = wallZPlane;
        }
    }
}

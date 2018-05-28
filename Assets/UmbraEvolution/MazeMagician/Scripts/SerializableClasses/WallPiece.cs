//Name: Robert MacGillivray
//File: WallPiece.cs
//Date: Jan.11.2017
//Purpose: To hold information about 3D wall pieces

//Last Updated: Jan.11.2017 by Robert MacGillivray

using UnityEngine;

namespace UmbraEvolution
{
    [System.Serializable]
    public class WallPiece
    {
        public GameObject wallPrefab;
        public float wallHeight;

        public WallPiece (GameObject wallPrefab, float wallHeight)
        {
            this.wallPrefab = wallPrefab;
            this.wallHeight = wallHeight;
        }
    }
}

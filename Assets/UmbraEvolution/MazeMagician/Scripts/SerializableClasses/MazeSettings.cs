//Name: Robert MacGillivray
//File: MazeSettings.cs
//Date: Aug.03.2016
//Purpose: A serializable class used to store information about maze settings for saving and loading

//Last Updated: Mar.03.2018 by Robert MacGillivray

using UnityEngine;

namespace UmbraEvolution
{
    [System.Serializable]
    public class MazeSettings
    {
        private string _mazeName;
        public string MazeName
        {
            get { return _mazeName; }
        }
        private MazeGenerator.MazeDimension _mazeDimension;
        public MazeGenerator.MazeDimension MazeDimension
        {
            get { return _mazeDimension; }
        }
        private int _seedValue;
        public int SeedValue
        {
            get { return _seedValue; }
        }
        private int _mazeWidth;
        public int MazeWidth
        {
            get { return _mazeWidth; }
        }
        private int _mazeLength;
        public int MazeLength
        {
            get { return _mazeLength; }
        }
        private float[] _mazePosition;
        public Vector3 MazePosition
        {
            get { return SerializeUnityThings.BackToVector3(_mazePosition); }
        }
        private float _mazeTileWidthAndLength;
        public float MazeTileWidthAndLength
        {
            get { return _mazeTileWidthAndLength; }
        }
        private float _defaultWallHeight;
        public float DefaultWallHeight
        {
            get { return _defaultWallHeight; }
        }
        private float _defaultFloorThickness;
        public float DefaultFloorThickness
        {
            get { return _defaultFloorThickness; }
        }
        private float _wallZPlane;
        public float WallZPlane
        {
            get { return _wallZPlane; }
        }
        private float _floorZPlane;
        public float FloorZPlane
        {
            get { return _floorZPlane; }
        }
        private bool _makeBraidMaze;
        public bool MakeBraidMaze
        {
            get { return _makeBraidMaze; }
        }
        private bool _deleteOutsideWalls;
        public bool DeleteOutsideWalls
        {
            get { return _deleteOutsideWalls; }
        }
        public int _outsideWallPiecesToDelete;
        public int OutsideWallPiecesToDelete
        {
            get { return _outsideWallPiecesToDelete; }
        }
        public MazeGenerator.OutsideWallDeleteMode _outsideWallDeleteMode;
        public MazeGenerator.OutsideWallDeleteMode OutsideWallDeleteMode
        {
            get { return _outsideWallDeleteMode; }
        }
        private bool _makeFloorExit;
        public bool MakeFloorExit
        {
            get { return _makeFloorExit; }
        }
        private MazeGenerator.FloorExitType _exitType;
        public MazeGenerator.FloorExitType ExitType
        {
            get { return _exitType; }
        }
        private bool _makePlazas;
        public bool MakePlazas
        {
            get { return _makePlazas; }
        }
        private int _numberOfPlazas;
        public int NumberOfPlazas
        {
            get { return _numberOfPlazas; }
        }
        private int _plazaPlacementAttempts;
        public int PlazaPlacementAttempts
        {
            get { return _plazaPlacementAttempts; }
        }
        private bool _differentCorners;
        public bool DifferentCorners
        {
            get { return _differentCorners; }
        }
        private bool _differentEnds;
        public bool DifferentEnds
        {
            get { return _differentEnds; }
        }

        public MazeSettings(string mazeName, MazeGenerator.MazeDimension mazeDimension, int seedValue, int mazeWidth, int mazeLength, Vector3 mazePosition, float mazeTileWidthAndLength,
            float defaultWallHeight, float defaultFloorThickness, float wallZPlane, float floorZPlane, bool makeBraidMaze, bool makeFloorExit, MazeGenerator.FloorExitType exitType, 
            bool deleteOutsideWalls, int outsideWallPiecesToDelete, MazeGenerator.OutsideWallDeleteMode outsideWallDeleteMode, bool makePlazas, int numberOfPlazas, int plazaPlacementAttempts, bool differentCorners, bool differentEnds)
        {
            _mazeName = mazeName;
            _mazeDimension = mazeDimension;
            _seedValue = seedValue;
            _mazeWidth = mazeWidth;
            _mazeLength = mazeLength;
            _mazePosition = SerializeUnityThings.VectorConversion(mazePosition);
            _mazeTileWidthAndLength = mazeTileWidthAndLength;
            _defaultWallHeight = defaultWallHeight;
            _defaultFloorThickness = defaultFloorThickness;
            _wallZPlane = wallZPlane;
            _floorZPlane = floorZPlane;
            _makeBraidMaze = makeBraidMaze;
            _makeFloorExit = makeFloorExit;
            _exitType = exitType;
            _deleteOutsideWalls = deleteOutsideWalls;
            _outsideWallPiecesToDelete = outsideWallPiecesToDelete;
            _outsideWallDeleteMode = outsideWallDeleteMode;
            _makePlazas = makePlazas;
            _numberOfPlazas = numberOfPlazas;
            _plazaPlacementAttempts = plazaPlacementAttempts;
            _differentCorners = differentCorners;
            _differentEnds = differentEnds;
        }
    }
}

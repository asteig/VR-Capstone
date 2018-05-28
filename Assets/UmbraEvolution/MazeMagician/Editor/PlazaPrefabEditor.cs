//Name: Robert MacGillivray
//Date: Aug.05.2016
//File: PlazaPrefabEditor.cs
//Purpose: To create a clean custom inspector for the PlazaPrefab component

//Last Updated: Aug.05.2016 by Robert MacGillivray

using UnityEngine;
using UnityEditor;

namespace UmbraEvolution
{
    [CustomEditor(typeof(PlazaPrefab))]
    public class PlazaPrefabEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            PlazaPrefab plazaPrefab = (PlazaPrefab)target;

            EditorGUILayout.PropertyField(serializedObject.FindProperty("width"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("length"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("height"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("fixedPosition"));
            if (plazaPrefab.fixedPosition)
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("xPosition"));
                EditorGUILayout.PropertyField(serializedObject.FindProperty("zPosition"));
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(InteractionHandler))]
class DecalMeshHelperEditor : Editor {
  public override void OnInspectorGUI() {
      DrawDefaultInspector();
      InteractionHandler handler = (InteractionHandler)target;
      if(GUILayout.Button("Find Interactables"))
        handler.interactables = FindObjectsOfType<InteractableScript>();
  }
}

using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(MapCam2D))]
public class MapCap2DEditor : Editor {

    public override void OnInspectorGUI() {
        DrawDefaultInspector();

        var cam = (MapCam2D)target;

        if (GUILayout.Button("Memorize offset")) {
            cam.offset = cam.camera.transform.position - cam.target.transform.position;
        }
    }
}

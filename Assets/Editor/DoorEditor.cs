using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Door))]
public class DoorEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Door door = (Door)target;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Open"))
        {
            door.OpenDoor();
        }

        if (GUILayout.Button("Close"))
        {
            door.CloseDoor();
        }

        GUILayout.EndHorizontal();
    }

}

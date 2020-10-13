using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Interactable))]
public class InteractableEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Interactable actor = (Interactable)target;

        if(GUILayout.Button("Force Interact"))
        {
            actor.Interact();
        }
    }

}

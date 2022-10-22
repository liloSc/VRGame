using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.XR.Interaction.Toolkit;

[CustomEditor(typeof(SocketWithTagCheck))]
public class SocketWithTagEditor : XRSocketInteractorEditor

{
    private SerializedProperty targetTag = null;
    protected override void OnEnable()
    {
        base.OnEnable();
        targetTag = SerializedObject.FindProperty("targetTag");
    }

    protected override void DrawProperties()
    {
        base.DrawProperties();
        EditorGUILayout.PropertyField(targetTag);
    }
}

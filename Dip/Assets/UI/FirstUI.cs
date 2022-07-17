using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class FirstUI : EditorWindow
{
    [MenuItem("Window/UI Toolkit/FirstUI")]
    public static void ShowExample()
    {
        FirstUI wnd = GetWindow<FirstUI>();
        wnd.titleContent = new GUIContent("FirstUI");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;
        
        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/UI/FirstUI.uxml");
        VisualElement labelFromUXML = visualTree.Instantiate();
        root.Add(labelFromUXML);

    }
}
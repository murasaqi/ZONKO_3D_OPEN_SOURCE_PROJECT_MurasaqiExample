using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class ToggleMeshSetting
{
    public ToggleMeshRenderer toggleMeshRenderer;
    public bool isOn = true;
}

[Serializable]
public struct ToggleMeshGroupSetting
{
    
    public string groupName;
    public List<ToggleMeshSetting> toggleMeshSettings;
    
    public ToggleMeshGroupSetting(string groupName,List<ToggleMeshSetting> toggleMeshSettings)
    {
        this.toggleMeshSettings = toggleMeshSettings;
        this.groupName = groupName;
    }
    
    public void Invoke()
    {
        foreach (var toggleMeshSetting in toggleMeshSettings)
        {
            toggleMeshSetting.toggleMeshRenderer.ToggleMeshRenderers(toggleMeshSetting.isOn);
        }
    }
}

[ExecuteAlways]
public class ToggleMeshRendererGroup : MonoBehaviour
{

    public List<ToggleMeshSetting> toggleMeshSettings = new List<ToggleMeshSetting>();
    // Start is called before the first frame update
    
    public void Invoke()
    {
        foreach (var toggleMeshSetting in toggleMeshSettings)
        {
            if (toggleMeshSetting.isOn != toggleMeshSetting.toggleMeshRenderer.isOn)
            {
                toggleMeshSetting.toggleMeshRenderer.ToggleMeshRenderers(toggleMeshSetting.isOn);    
            }
            
        }
    }

    private void Start()
    {
        Invoke();
    }


    // public void Invoke(string groupName)
    // {
    //     foreach (var toggleMeshGroupSetting in toggleMeshGroupSettings)
    //     {
    //         if (toggleMeshGroupSetting.groupName == groupName)
    //         {
    //             toggleMeshGroupSetting.Invoke();
    //         }
    //     }
    // }
    
}

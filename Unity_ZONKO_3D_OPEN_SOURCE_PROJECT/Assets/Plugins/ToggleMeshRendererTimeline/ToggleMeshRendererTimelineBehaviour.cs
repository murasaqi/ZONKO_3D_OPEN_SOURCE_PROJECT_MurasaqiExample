using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;


[Serializable]
public class ToggleMeshClipSetting
{
    public ExposedReference<ToggleMeshRenderer> toggleMeshRenderer;
    public bool isOn;

    public ToggleMeshClipSetting()
    {
        toggleMeshRenderer = new ExposedReference<ToggleMeshRenderer>();
        isOn = false;
    }
}
[Serializable]
public class ToggleMeshRendererTimelineBehaviour : PlayableBehaviour
{

    public bool disableUnBindObject = false;
    public List<ToggleMeshClipSetting> toggleMeshClipSettings = new List<ToggleMeshClipSetting>();
    
    
    public List<ToggleMeshSetting> toggleMeshSettings = new List<ToggleMeshSetting>();
    public override void OnPlayableCreate (Playable playable)
    {
        toggleMeshSettings.Clear();
        foreach (var toggleMeshClipSetting in toggleMeshClipSettings)
        {
            toggleMeshSettings.Add(new ToggleMeshSetting()
            {
                toggleMeshRenderer = toggleMeshClipSetting.toggleMeshRenderer.Resolve(playable.GetGraph().GetResolver()),
                isOn = toggleMeshClipSetting.isOn
            });
        }
    }

    // public void CopyTo(List<ToggleMeshSetting> toggleMeshSettings)
    // {
    //     
    //     var countDiff = toggleMeshSettings.Count - toggleMeshClipSettings.Count;
    //     if (countDiff > 0)
    //     {
    //         for (int j = 0; j < countDiff; j++)
    //         {
    //             toggleMeshClipSettings.Add(new ToggleMeshClipSetting());
    //         }
    //     }
    //     else if (countDiff < 0)
    //     {
    //         // for (int j = 0; j < -countDiff; j++)
    //         // {
    //         //     input.toggleMeshSettings.RemoveAt(trackBinding.toggleMeshSettings.Count - 1);
    //         // }
    //     }
    //
    //     foreach (var toggleMeshSetting in toggleMeshSettings)
    //     {
    //         
    //     }
    // }
}

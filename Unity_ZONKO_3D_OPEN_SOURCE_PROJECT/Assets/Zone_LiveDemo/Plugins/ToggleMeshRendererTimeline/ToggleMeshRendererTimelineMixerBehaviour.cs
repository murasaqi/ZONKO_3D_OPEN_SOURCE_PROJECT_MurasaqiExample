using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class ToggleMeshRendererTimelineMixerBehaviour : PlayableBehaviour
{
    
    private ToggleMeshRendererTimelineBehaviour currentBehaviour;
    // NOTE: This function is called at runtime and edit time.  Keep that in mind when setting the values of properties.
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        ToggleMeshRendererGroup trackBinding = playerData as ToggleMeshRendererGroup;

        if (!trackBinding)
            return;

        int inputCount = playable.GetInputCount ();

        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);
            ScriptPlayable<ToggleMeshRendererTimelineBehaviour> inputPlayable = (ScriptPlayable<ToggleMeshRendererTimelineBehaviour>)playable.GetInput(i);
            ToggleMeshRendererTimelineBehaviour input = inputPlayable.GetBehaviour ();
            
            // var countDiff = trackBinding.toggleMeshSettings.Count - input.toggleMeshSettings.Count;
            // if (countDiff > 0)
            // {
            //     for (int j = 0; j < countDiff; j++)
            //     {
            //         input.toggleMeshSettings.Add(new ToggleMeshSetting());
            //     }
            //     
            // }
            // else if (countDiff < 0)
            // {
            //     for (int j = 0; j < -countDiff; j++)
            //     {
            //         input.toggleMeshSettings.RemoveAt(trackBinding.toggleMeshSettings.Count - 1);
            //     }
            // }
            //
            // for (int j = 0; j < input.toggleMeshSettings.Count; j++)
            // {
            //     input.toggleMeshSettings[j].toggleMeshRenderer = trackBinding.toggleMeshSettings[j].toggleMeshRenderer;
            // }
            

            if (inputWeight > 0 && currentBehaviour!= input)
            {
               
                // Debug.Log(i);
                for (int j = 0; j < trackBinding.toggleMeshSettings.Count; j++)
                {
                   var find= input.toggleMeshSettings.Find(x =>
                        x.toggleMeshRenderer == trackBinding.toggleMeshSettings[j].toggleMeshRenderer);

                   if (find != null)
                   {
                       trackBinding.toggleMeshSettings[j].isOn = find.isOn;
                   }
                   else
                   {
                       if(input.disableUnBindObject) trackBinding.toggleMeshSettings[j].isOn = false;
                   }

                }
                trackBinding.Invoke();
                currentBehaviour = input;
            }
            // Use the above variables to process each frame of this playable.
            
        }
    }
}

using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class ToggleMeshRendererTimelineClip : PlayableAsset, ITimelineClipAsset
{
    public ToggleMeshRendererTimelineBehaviour template = new ToggleMeshRendererTimelineBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.None; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<ToggleMeshRendererTimelineBehaviour>.Create (graph, template);
        ToggleMeshRendererTimelineBehaviour clone = playable.GetBehaviour ();
        return playable;
    }
}

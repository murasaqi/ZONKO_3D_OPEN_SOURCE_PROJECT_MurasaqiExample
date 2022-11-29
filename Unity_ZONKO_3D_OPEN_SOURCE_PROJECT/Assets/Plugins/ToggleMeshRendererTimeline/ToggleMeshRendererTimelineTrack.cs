using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[TrackColor(1f, 0.2644264f, 0.2327043f)]
[TrackClipType(typeof(ToggleMeshRendererTimelineClip))]
[TrackBindingType(typeof(ToggleMeshRendererGroup))]
public class ToggleMeshRendererTimelineTrack : TrackAsset
{
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
        return ScriptPlayable<ToggleMeshRendererTimelineMixerBehaviour>.Create (graph, inputCount);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[ExecuteAlways]
public class ToggleMeshRenderer : MonoBehaviour
{

    [SerializeField] private List<Renderer> renderers = new List<Renderer>();
    [SerializeField]private bool _isOn = true;
    public bool isOn
    {
        get => _isOn;
        set
        {
            _isOn = value;
            foreach (var renderer in renderers)
            {
                renderer.enabled = _isOn;
            }
        }
    }
    void Start()
    {
        FindMeshRenderer();
    }

    [ContextMenu( "Find Mesh Renderer" )]
    public void FindMeshRenderer()
    {
        renderers = GetComponentsInChildren<Renderer>().ToList();
    }

    public void ToggleMeshRenderers(bool toggle)
    {
        // Debug.Log($"{name}: {toggle}");
        foreach (var meshRenderer in renderers)
        {
            meshRenderer.enabled = toggle;
        }
        _isOn = toggle;
    }
    
    // [ContextMenu( "Toggle Mesh Renderers" )]
    // public void ToggleMeshRenderers()
    // {
    //     foreach (var meshRenderer in renderers)
    //     {
    //         meshRenderer.enabled = !meshRenderer.enabled;
    //     }
    // }
    //
    
    // [ContextMenu("Toggle Mesh Renderer")]
    // public void ToggleMeshRenderers()
    // {
    //     foreach (var meshRenderer in renderers)
    //     {
    //         meshRenderer.enabled = !meshRenderer.enabled;
    //     }
    // }
    // Update is called once per frame
    void Update()
    {
        
    }
}

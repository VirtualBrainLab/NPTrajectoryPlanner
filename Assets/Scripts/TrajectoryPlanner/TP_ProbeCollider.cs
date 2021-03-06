using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TrajectoryPlanner;

public class TP_ProbeCollider : MonoBehaviour
{
    [SerializeField] ProbeManager pcontroller;
    private TrajectoryPlannerManager tpmanager;

    private void Start()
    {
        tpmanager = GameObject.Find("main").GetComponent<TrajectoryPlannerManager>();
    }

    private void OnDestroy()
    {
        //tpmanager.
    }

    private void OnMouseDown()
    {
        // ignore mouse clicks if we're over a UI element
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        // If someone clicks on a probe, immediately make that the active probe and claim probe control
        tpmanager.SetActiveProbe(pcontroller);
        pcontroller.DragMovementClick();
    }

    private void OnMouseDrag()
    {
        pcontroller.DragMovementDrag();
    }

    private void OnMouseUp()
    {
        pcontroller.DragMovementRelease();
    }
}

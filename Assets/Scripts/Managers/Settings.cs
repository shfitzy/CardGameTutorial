﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CardGameDemo
{
    public static class Settings
    {
        public static GameManager gameManager;

        private static ResourcesManager _resourcesManager;

        public static ResourcesManager GetResourcesManager()
        {
            if(_resourcesManager == null)
            {
                _resourcesManager = Resources.Load("ResourcesManager") as ResourcesManager;
                _resourcesManager.Init();
            }

            return _resourcesManager;
        }

        public static List<RaycastResult> GetUIObjects()
        {
            PointerEventData pointerData = new PointerEventData(EventSystem.current)
            {
                position = Input.mousePosition
            };

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);

            return results;
        }

        public static void SetParentForCard(Transform c, Transform p)
        {
            c.SetParent(p);
            c.localPosition = Vector3.zero;
            c.localEulerAngles = Vector3.zero;
            c.localScale = Vector3.one;
        }
    }
}
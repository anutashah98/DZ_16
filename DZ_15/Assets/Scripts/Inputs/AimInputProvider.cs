using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class AimInputProvider : IAimInputProvider
    {
        
        public event Action OnLaunch;
        private Vector3 _aimTarget;
        
        public void OnUpdate()
        {
            ProcessLaunchInput();
            ProcessAimInput();
        }
        
        public Vector2 GetAimTarget()
        {
            return _aimTarget;
        }

        private void ProcessAimInput()
        {
            _aimTarget = Input.mousePosition;
        }

        private void ProcessLaunchInput()
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                OnLaunch?.Invoke();
            }
        }

    }
}
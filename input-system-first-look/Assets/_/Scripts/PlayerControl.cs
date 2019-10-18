namespace GiantCroissant.InputSystemFirstLook
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerControl : MonoBehaviour
    {
        public float moveSpeed;
        public GameObject laserPrefab;

        public Transform leftPoint;
        public Transform rightPoint;
        
        private GameControls _gameControls;

        private bool fromLeftPoint;

        void Awake()
        {
            _gameControls = new GameControls();
        }

        void Start()
        {
            _gameControls.Battle.Fire.performed += context =>
            {
                var createdInstance = GameObject.Instantiate(laserPrefab);
                if (fromLeftPoint)
                {
                    createdInstance.transform.SetParent(leftPoint);
                    createdInstance.transform.localPosition = Vector3.zero;
                    createdInstance.transform.SetParent(null);
                }
                else
                {
                    createdInstance.transform.SetParent(rightPoint);
                    createdInstance.transform.localPosition = Vector3.zero;
                    createdInstance.transform.SetParent(null);
                }

                fromLeftPoint = !fromLeftPoint;
            };
        }

        private void OnEnable()
        {
            _gameControls.Enable();
        }

        private void OnDisable()
        {
            _gameControls.Disable();
        }

        void Update()
        {
            var moveValue = _gameControls.Battle.Move.ReadValue<Vector2>();
            Move((moveValue));
        }

        void Move(Vector2 direction)
        {
            if (direction.sqrMagnitude < 0.01)
            {
                return;
            }

            var adjustedDirection = direction * moveSpeed * Time.deltaTime;
            transform.position += new Vector3(adjustedDirection.x, adjustedDirection.y, 0);
        }
    }
}

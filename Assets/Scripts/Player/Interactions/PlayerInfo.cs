using System;
using UnityEditorInternal;
using UnityEngine;

namespace Player.Interactions
{
    public class PlayerInfo : MonoBehaviour
    {
        public int drugs;
        public int hp;
        [SerializeField] private int maxHP;

        private void Awake()
        {
            drugs = 0;
            hp = maxHP;
        }
    }
}
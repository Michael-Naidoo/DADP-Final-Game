using System;
using UnityEditorInternal;
using UnityEngine;

namespace Player.Interactions
{
    public class PlayerInfo : MonoBehaviour
    {
        public int drugs;
        public int hp;
        public int maxHP;
        public int keyRef;
        public GameObject[] keys;


        private void Awake()
        {
            drugs = 0;
            hp = maxHP;
            keyRef = 0;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Patterns.Observer
{
    public class BadScoreDisplayer : MonoBehaviour
    {
        public static BadScoreDisplayer instance;

        [SerializeField]
        private TextMeshProUGUI scoreText;

        private int scorePoints;


        private void Awake() 
        {
            instance = this;
        }

        private void Start() 
        {
            UpdateScoreText();
        }

        public void ModifyScorePoints(int modifier)
        {
            scorePoints += modifier;

            UpdateScoreText();
        }

        private void UpdateScoreText()
        {
            scoreText.text = $"Score = {scorePoints}";
        }
    }

    public class BadEnemyStats : MonoBehaviour
    {
        private float health;

        private int scorePoints;

        private void OnEnemyHit(int damagePoints)
        {
            health -= damagePoints;

            if(health <= 0)
            {
                BadScoreDisplayer.instance.ModifyScorePoints(scorePoints); // directly access the instance :(
            }
        }
    }
}
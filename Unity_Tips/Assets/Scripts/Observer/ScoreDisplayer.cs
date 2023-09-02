using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Patterns.Observer
{
    public class ScoreDisplayer : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI scoreText;

        private int scorePoints;


        private void Start() 
        {
            UpdateScoreText();
        }

        private void OnEnable() 
        {
            EnemyStats.enemyDeathEvent += ModifyScorePoints; // subscribe to enemy's event
        }

        private void OnDisable() 
        {
            EnemyStats.enemyDeathEvent -= ModifyScorePoints; // unsubscribe from enemy's event
        }


        private void ModifyScorePoints(int modifier)
        {
            scorePoints += modifier;

            UpdateScoreText();
        }

        private void UpdateScoreText()
        {
            scoreText.text = $"Score = {scorePoints}";
        }
    }
}
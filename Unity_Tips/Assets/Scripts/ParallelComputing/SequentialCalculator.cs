using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

namespace Tips.ProceduralProgramming
{
    public class SequentialCalculator : MonoBehaviour
    {
        [SerializeField]
        private int _dataSize = 100000000;

        private NativeArray<int> _dataArray;

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.S))
            {
                Execute();
            }
        }

        private void Execute()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Restart();

            _dataArray = new NativeArray<int>(_dataSize, Allocator.Persistent);

            for (int i = 0; i < _dataSize; i++)
            {
                _dataArray[i] = UnityEngine.Random.Range(1, 101);
            }

            int result = 0;
            for (int i = 0; i < _dataSize; i++)
            {
                result += _dataArray[i];
            }

            stopWatch.Stop();
            PrintTime(result, stopWatch.Elapsed);
            _dataArray.Dispose();
        }

        private void PrintTime(int result, in TimeSpan timeSpan)
        {
            string time = String.Format("{0:00}.{1:00}", timeSpan.Seconds, timeSpan.Milliseconds / 10);

            UnityEngine.Debug.Log($"Sequential Result = {result} | {System.DateTime.Now.TimeOfDay} - RunTime: {time}");
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;
using Unity.Burst;

namespace Tips.ProceduralProgramming
{
    public class ParallelCalculator : MonoBehaviour
    {
        [SerializeField]
        private int _dataSize = 100000000;
        [SerializeField]
        private int _numOfThreads = 4;

        private NativeArray<int> _dataArray;
        private NativeArray<int> _partialSums;

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.P))
            {
                Execute();
            }
        }

        private void Execute()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Restart();
            
            _dataArray = new NativeArray<int>(_dataSize, Allocator.Persistent);
            _partialSums = new NativeArray<int>(_numOfThreads, Allocator.Persistent);

            for (int i = 0; i < _dataSize; i++)
            {
                _dataArray[i] = UnityEngine.Random.Range(1, 101);
            }


            JobHandle currentJobHandler = default;
            for (int i = 0; i < _numOfThreads; i++)
            {
                SumJob sumJob = new SumJob
                {
                    startIndex = i * (_dataSize / _numOfThreads),
                    endIndex = (i + 1) * (_dataSize / _numOfThreads),
                    dataArray = _dataArray,
                    partialSums = _partialSums,
                    threadIndex = i
                };
                JobHandle jobHandler = sumJob.Schedule(currentJobHandler);
                currentJobHandler = jobHandler;
            }

            currentJobHandler.Complete();

            int totalSum = 0;
            for (int i = 0; i < _numOfThreads; i++)
            {
                totalSum += _partialSums[i];
            }

            stopWatch.Stop();
            PrintTime(totalSum, stopWatch.Elapsed);

            _dataArray.Dispose();
            _partialSums.Dispose();
        }

        private void PrintTime(int result, in TimeSpan timeSpan)
        {
            string time = String.Format("{0:00}.{1:00}", timeSpan.Seconds, timeSpan.Milliseconds / 10);

            UnityEngine.Debug.Log($"Parallel Result = {result} | {System.DateTime.Now.TimeOfDay} - RunTime: {time}");
        }

        [BurstCompile]
        private struct SumJob : IJob
        {
            public int startIndex;
            public int endIndex;
            public NativeArray<int> dataArray;
            public NativeArray<int> partialSums;
            public int threadIndex;

            public void Execute()
            {
                int sum = 0;

                for (int i = startIndex; i < endIndex; i++)
                {
                    sum += dataArray[i];
                }

                partialSums[threadIndex] = sum;
            }
        }
    }
}
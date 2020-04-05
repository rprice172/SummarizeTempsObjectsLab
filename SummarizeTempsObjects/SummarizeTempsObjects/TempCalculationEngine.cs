using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            int sumOfTemps = 0;

            foreach (int temp in _temperatures)
            {
                sumOfTemps += temp;
            }

            int averageTemps = sumOfTemps / _temperatures.Count;

            return averageTemps; 
        }

        public int TempsAboveThreshold(int threshold)
        {
            int tempsCount = 0;
            foreach (int temp in _temperatures)
            {
                
                if (temp > threshold)
                {
                    tempsCount += 1;
                }
            }

            return tempsCount; 
        }

        public int TempsBelowThreshold(int threshold)
        {
            int tempsCount = 0;
            foreach ( int temp in _temperatures)
                if ( temp < threshold)
                {
                    tempsCount += 1;
                }
            return tempsCount; 
        }

        public int TempsAtThreshold(int threshold)
        {
            int tempsCount = 0;
            foreach ( int temp in _temperatures)
                if ( temp == threshold)
                {
                    tempsCount += 1;
                }

            return tempsCount; 
        }

        public int NumberOfTemperatures()
        {
            return _temperatures.Count; 
        }
    }
}

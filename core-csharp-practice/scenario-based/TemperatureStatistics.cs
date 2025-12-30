using System;

class TemperatureStatistics
{
    private double[,] readings;

    public TemperatureStatistics(double[,] inputData)
    {
        readings = inputData;
    }

    static void Main()
    {
        double[,] weeklyData = new double[7, 24];
        CaptureInput(weeklyData);

        TemperatureStatistics stats = new TemperatureStatistics(weeklyData);
        stats.ShowHotAndColdDays();
        stats.ShowAveragePerDay();
    }

    static void CaptureInput(double[,] data)
    {
        Console.WriteLine("Provide hourly temperatures for each day:");

        for (int d = 0; d < data.GetLength(0); d++)
        {
            Console.WriteLine($"Day {d + 1}");
            for (int h = 0; h < data.GetLength(1); h++)
            {
                data[d, h] = double.Parse(Console.ReadLine());
            }
        }
    }

    public void ShowHotAndColdDays()
    {
        int hotIndex = 0, coldIndex = 0;
        double highestTemp = readings[0, 0];
        double lowestTemp = readings[0, 0];

        for (int d = 0; d < readings.GetLength(0); d++)
        {
            double dailyMax = readings[d, 0];
            double dailyMin = readings[d, 0];

            for (int h = 0; h < readings.GetLength(1); h++)
            {
                if (readings[d, h] > dailyMax)
                    dailyMax = readings[d, h];

                if (readings[d, h] < dailyMin)
                    dailyMin = readings[d, h];
            }

            if (dailyMax > highestTemp)
            {
                highestTemp = dailyMax;
                hotIndex = d;
            }

            if (dailyMin < lowestTemp)
            {
                lowestTemp = dailyMin;
                coldIndex = d;
            }
        }

        Console.WriteLine($"Highest temperature recorded on Day {hotIndex + 1}");
        Console.WriteLine($"Lowest temperature recorded on Day {coldIndex + 1}");
    }

    public void ShowAveragePerDay()
    {
        for (int d = 0; d < readings.GetLength(0); d++)
        {
            double dayTotal = 0;

            for (int h = 0; h < readings.GetLength(1); h++)
            {
                dayTotal += readings[d, h];
            }

            double avg = Math.Round(dayTotal / readings.GetLength(1), 2);
            Console.WriteLine($"Day {d + 1} average temperature: {avg}");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        // Read input
        Console.Write("Enter the number of items: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];
        Console.WriteLine("Enter the items values:");
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        // Sort the array
        Array.Sort(a);

        // Calculate the median
        int medianIndex = n / 2;
        double median;
        if (n % 2 == 0)
        {
            median = (a[medianIndex - 1] + a[medianIndex]) / 2.0;
        }
        else
        {
            median = a[medianIndex];
        }
        Console.WriteLine("Median: " + median);

        // Calculate the mode
        int mode = 0;
        int modeCount = 0;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = i + 1; j < n; j++)
            {
                if (a[i] == a[j])
                {
                    count++;
                }
            }
            if (count > modeCount)
            {
                modeCount = count;
                mode = a[i];
            }
        }
        Console.WriteLine("Mode: " + mode);

        // Calculate the range
        int range = a[n - 1] - a[0];
        Console.WriteLine("Range: " + range);

        // Calculate the quartiles
        int q1Index = n / 4;
        double q1;
        if (n % 4 == 0)
        {
            q1 = (a[q1Index - 1] + a[q1Index]) / 2.0;
        }
        else
        {
            q1 = a[q1Index];
        }
        Console.WriteLine("Q1: " + q1);

        int q3Index = 3 * n / 4;
        double q3;
        if (n % 4 == 0)
        {
            q3 = (a[q3Index - 1] + a[q3Index]) / 2.0;
        }
        else
        {
            q3 = a[q3Index];
        }
        Console.WriteLine("Q3: " + q3);

        // Calculate the P90
        int p90Index = (int)Math.Ceiling(0.9 * n) - 1;
        double p90 = a[p90Index];
        Console.WriteLine("P90: " + p90);

        // Calculate the interquartile range
        double iqr = q3 - q1;
        Console.WriteLine("Interquartile range: " + iqr);

        // Calculate the outlier boundaries
        double lowerBound = q1 - 1.5 * iqr;
        double upperBound = q3 + 1.5 * iqr;
        Console.WriteLine("Outlier boundaries: " + lowerBound + " - " + upperBound);

        // Check if input values are outliers
        Console.Write("Enter a value to check if it is an outlier: ");
        int value = int.Parse(Console.ReadLine());
        if (value < lowerBound || value > upperBound)
        {
            Console.WriteLine(value + " is an outlier.");
        }
        else
        {
            Console.WriteLine(value + " is not an outlier.");
        }
    }
}

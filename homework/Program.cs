

class Program
{
    static void Main(string[] args)
    {
          
    }


    //ex:1
    //4n +2
    //O(n)
    public int CalculateOddSum(int[] array)
    {
        // +1
        int sum = 0;

        // +n
        foreach (int num in array)
        {
            // +2 
            if (num % 2 != 0)
            {
                // +1 
                sum += num;
            }
        }

        // +1
        return sum;
    }

    //ex:2
    //6n +2
    //O(n)
    public int FindMaximumTwo(int[] array)
    {
      
        // +1
        int maxSum = array[0] + array[1];

        // +n-1
        for (int i = 1; i < array.Length - 1; i++)
        {
            // +3 
            int sum = array[i] + array[i + 1];

            // +1 
            if (sum > maxSum)
            {
                // +1 
                maxSum = sum;
            }
        }

        // +1
        return maxSum;
    }

    //ex:3
    //2n+1
    //O(n)
    public bool ContainsNumber(int[] array, int number)
    {
        // +n
        foreach (int num in array)
        {
            // +n
            if (num == number)
            {
                // +1
                return true;
            }
        }
        // +1
        return false;
    }

    //ex4
    //O(n^3)
    public int SumOfAllTriplets(int[] array)
    {
        //+1
        int maxSum = int.MinValue;
        //n
        for (int i = 0; i < array.Length - 2; i++)
        {
            //n       +1          +1                  +1
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                //       n            n                 n
                for (int k = j + 1; k < array.Length; k++)
                {
                    int sum = array[i] + array[j] + array[k];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
        }
        //1
        return maxSum;
    }


    //ex:5 
    //12n+1
    //(n^2)
    public void FindLastPairWithProduct(int[] array, int product)
    {
        //  +n       +1                    +n   +n
        for (int i = array.Length - 1; i > 0; i--)
        {
            //+n      +n          +n     +n
            for (int j = i - 1; j >= 0; j--)
            {
                //    +n     +n     +n  +n
                if (array[i] * array[j] == product)
                {
                    //+n
                   Console.WriteLine(array[i].ToString(), array[j].ToString());
                    break;
                }
            }
        }       
    }

    //ex:6
    //4n+2
    //(n)
    public int CountEvenNumbers(int[] array)
    {
        //+1
        int count = 0;
        //+N
        foreach (int num in array)
        {
            //+2n
            if (num % 2 == 0)
            {
                //+n
                count++;
            }
        }
        //+1
        return count;
    }


    //ex:8
    //O(n^2)
    public List<(int, int)> FindPairsWithSum(int[] array, int sum)
    {
        //1
        var pairs = new List<(int, int)>();
        //n
        for (int i = 0; i < array.Length - 1; i++)
        {
            //n
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == sum)
                {
                    pairs.Add((array[i], array[j]));
                }
            }
        }
        //1
        return pairs;
    }


    //ex9
    //n+4
    //O(n)
    public Dictionary<int, int> CountFrequency(int[] array)
    {
        //1
        var times = new Dictionary<int, int>();
        //n
        foreach (int num in array)
        {
            //1+1
            if (times.ContainsKey(num))
            {  
                times[num]++;
            }
            else
            {
                times[num] = 1;
            }
        }
        //1
        return times;
    }

    //ex:10
    //3n+2
    //O(n)
    public int FindMaxSubarraySum(int[] array)
    {
        // +1 
        int maxSoFar = array[0], maxEndingHere = array[0];

        // +N
        for (int i = 1; i < array.Length; i++)
        {
            // +2 
            maxEndingHere = Math.Max(array[i], maxEndingHere + array[i]);

            // +1 
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }
        // +1 
        return maxSoFar;
    }

}



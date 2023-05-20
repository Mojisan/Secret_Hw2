using System;
class Program
{
    public static void Main(string[] args)
    {
        //pascalTriangle();
        //DNAReplication();
        //LegendaryMatrix();
        //Business();
    }

    static void pascalTriangle()
    {
        int n;
        Console.Write("Input number : ");
        n = int.Parse(Console.ReadLine());
        while (true)
        {
            if (n < 0)
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
                Console.WriteLine("------------------------");
                Console.Write("Input number : ");
                n = int.Parse(Console.ReadLine());
            }
            else
            {
                break;
            }
        }
        for (int row = 0; row <= n; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                Console.Write("{0} ", pascalMethod(row, col));
            }
            Console.WriteLine();
        }
    }

    static int pascalMethod(int row, int col)
    {
        if (row <= 1)
        {
            return 1;
        }
        else if (row > 1 && (col == 0 || col == row))
        {
            return 1;
        }
        else if (row > 1 && (col == 1 || col == row - 1))
        {
            return row;
        }
        else
        {
            return pascalMethod(row - 1, col - 1) + pascalMethod(row - 1, col);
        }
    }

    static void DNAReplication()
    {
        bool again = true;
        do
        {
            Console.Write("Input half DNA : ");
            string dna = Console.ReadLine();
            if (IsValidSequence(dna))
            {
                Console.WriteLine("Current half DNA sequence : {0}", dna);
                while (true)
                {
                    Console.Write("Do you want to replicate it ? (Y/N) : ");
                    string rep = Console.ReadLine();
                    if (rep == "Y")
                    {
                        Console.WriteLine("Replicated half DNA sequence : {0}", ReplicateSeqeunce(dna));
                        break;
                    }
                    else if (rep == "N")
                    {
                        again = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }
            while (true)
            {
                Console.Write("Do you want to process another sequence ? (Y/N) : ");
                string check = Console.ReadLine();
                if (check == "Y")
                {
                    again = true;
                    break;
                }
                else if (check == "N")
                {
                    again = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            }
        }
        while (again);
    }

    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSeqeunce(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }

    static void LegendaryMatrix()
    {
        bool check = true;
        while (check)
        {
            Console.Write("Input + or - : ");
            string symbol = Console.ReadLine();
            switch (symbol)
            {
                case "+":
                    {
                        Console.Write("Input row of matrix : ");
                        int row = int.Parse(Console.ReadLine());
                        Console.Write("Input col of matrix : ");
                        int col = int.Parse(Console.ReadLine());
                        float[,] matrixA = new float[row, col];
                        float[,] matrixB = new float[row, col];
                        Console.WriteLine("Input matrix A : ");
                        for (int rowA = 0; rowA <= row - 1; rowA++)
                        {
                            for (int colA = 0; colA <= col - 1; colA++)
                            {
                                matrixA[rowA, colA] = float.Parse(Console.ReadLine());
                            }
                        }
                        Console.WriteLine("Input matrix B : ");
                        for (int rowB = 0; rowB <= row - 1; rowB++)
                        {
                            for (int colB = 0; colB <= col - 1; colB++)
                            {
                                matrixB[rowB, colB] = float.Parse(Console.ReadLine());
                            }
                        }
                        for (int r = 0; r <= row - 1; r++)
                        {
                            for (int c = 0; c <= col - 1; c++)
                            {
                                Console.Write("{0} ", matrixA[r, c] + matrixB[r, c]);
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                case "-":
                    {
                        Console.Write("Input row of matrix : ");
                        int row = int.Parse(Console.ReadLine());
                        Console.Write("Input col of matrix : ");
                        int col = int.Parse(Console.ReadLine());
                        float[,] matrixA = new float[row, col];
                        float[,] matrixB = new float[row, col];
                        Console.WriteLine("Input matrix A : ");
                        for (int rowA = 0; rowA <= row - 1; rowA++)
                        {
                            for (int colA = 0; colA <= col - 1; colA++)
                            {
                                matrixA[rowA, colA] = float.Parse(Console.ReadLine());
                            }
                        }
                        Console.WriteLine("Input matrix B : ");
                        for (int rowB = 0; rowB <= row - 1; rowB++)
                        {
                            for (int colB = 0; colB <= col - 1; colB++)
                            {
                                matrixB[rowB, colB] = float.Parse(Console.ReadLine());
                            }
                        }
                        for (int r = 0; r <= row - 1; r++)
                        {
                            for (int c = 0; c <= col - 1; c++)
                            {
                                Console.Write("{0} ", matrixA[r, c] - matrixB[r, c]);
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                default:
                    {
                        check = false;
                        break;
                    }
            }
        }
    }

    static void Business()
    {
        Console.Write("Input N : ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Input K : ");
        int K = int.Parse(Console.ReadLine());
        int[] phase = new int[N];
        bool check = true;
        int result = 0, temp = 0;
        if (N >= 1 && N <= 10000 && K >= 1 && K <= 100)
        {
            for (int i = 0; i < N && check; i++)
            {
                Console.Write("Phase {0} : ", i + 1);
                phase[i] = int.Parse(Console.ReadLine());
                if (phase[i] > 500)
                {
                    check = false;
                }
            }
            for (int i = K; i < N - K; i++) {
                temp = phase[i];
                for (int j = 1; j <= K; j++) {
                    temp = temp + phase[i + j] + phase[i - j];
                }
                result = max(temp, result);
            }
            Console.WriteLine("Number of people : {0}", result);
        }
    }

    static int max(int x, int y) {
        if (x > y) {
            return x;
        }
        return y;
    }
}
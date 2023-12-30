using System;
using System.Linq;

internal class Matrix
{
    private int rows;
    private int columns;
    private int[][] matrix;

    public Matrix(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        matrix = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            matrix[i] = new int[columns];
        }
    }

    public int Rows
    {
        get { return rows; }
    }

    public int Columns
    {
        get { return columns; }
    }

    public int this[int row, int col]
    {
        get { return matrix[row][col]; }
        set { matrix[row][col] = value; }
    }

    public void Input(Random random)
    {
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
           
                matrix[i][j] = random.Next(1, 101);
            }
        }
    }

    public void Output()
    {
        Console.WriteLine("Matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i][j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public int Max()
    {
        return matrix.SelectMany(row => row).Max();
    }

    public int Min()
    {
        return matrix.SelectMany(row => row).Min();
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (m1.rows != m2.rows || m1.columns != m2.columns)
        {
            throw new ArgumentException("Matrices must have the same dimensions for addition.");
        }

        Matrix result = new Matrix(m1.rows, m1.columns);

        for (int i = 0; i < m1.rows; i++)
        {
            for (int j = 0; j < m1.columns; j++)
            {
                result[i, j] = m1[i, j] + m2[i, j];
            }
        }

        return result;
    }


    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        if (m1.rows != m2.rows || m1.columns != m2.columns)
        {
            throw new ArgumentException("Matrices must have the same dimensions for subtraction.");
        }

        Matrix result = new Matrix(m1.rows, m1.columns);

        for (int i = 0; i < m1.rows; i++)
        {
            for (int j = 0; j < m1.columns; j++)
            {
                result[i, j] = m1[i, j] - m2[i, j];
            }
        }

        return result;
    }

    public static Matrix operator *(Matrix matrix, int number)
    {
        Matrix result = new Matrix(matrix.rows, matrix.columns);

        for (int i = 0; i < matrix.rows; i++)
        {
            for (int j = 0; j < matrix.columns; j++)
            {
                result[i, j] = matrix[i, j] * number;
            }
        }

        return result;
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.rows != m2.rows || m1.columns != m2.columns)
        {
            throw new ArgumentException("Matrices must have the same dimensions for multiplication.");
        }

        Matrix result = new Matrix(m1.rows, m1.columns);

        for (int i = 0; i < m1.rows; i++)
        {
            for (int j = 0; j < m1.columns; j++)
            {
                result[i, j] = m1[i, j] * m2[i, j];
            }
        }

        return result;
    }


    public static bool operator ==(Matrix m1, Matrix m2)
    {
        if (ReferenceEquals(m1, m2))
        {
            return true;
        }

        if (m1 is null || m2 is null)
        {
            return false;
        }

        if (m1.rows != m2.rows || m1.columns != m2.columns)
        {
            return false;
        }

        for (int i = 0; i < m1.rows; i++)
        {
            for (int j = 0; j < m1.columns; j++)
            {
                if (m1[i, j] != m2[i, j])
                {
                    return false;
                }
            }
        }

        return true;
    }


    public static bool operator !=(Matrix m1, Matrix m2)
    {
        return !(m1 == m2);
    }


    public override bool Equals(object obj)
    {
        if (obj is Matrix matrix)
        {
            return this == matrix;
        }

        return false;
    }
    static void Main(string[] args)
    {
      
        Matrix matrix1 = new Matrix(3, 3);
        Matrix matrix2 = new Matrix(3, 3);

        Random random = new Random();
        matrix1.Input(random);
        matrix2.Input(random    );

        Console.WriteLine("Matrix 1:");
        matrix1.Output();

        Console.WriteLine("\nMatrix 2:");
        matrix2.Output();

        Matrix sum = matrix1 + matrix2;
        Console.WriteLine("\nSum of matrices:");
        sum.Output();


        Matrix difference = matrix1 - matrix2;
        Console.WriteLine("\nDifference of matrices:");
        difference.Output();

        int number = 2;
        Matrix productByScalar = matrix1 * number;
        Console.WriteLine($"\nMatrix multiplied by {number}:");
        productByScalar.Output();

        Matrix product = matrix1 * matrix2;
        Console.WriteLine("\nProduct of matrices:");
        product.Output();

  
        bool areEqual = matrix1 == matrix2;
        Console.WriteLine($"\nMatrices are equal: {areEqual}");

     
      
    }
}

    
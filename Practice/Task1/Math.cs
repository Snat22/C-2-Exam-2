namespace Task1;

public class Math1
{
    const double PI = 3.14;
    const double E = 2.71;

    public double Abs(double n)
    {
        if (n < 0)
        {
            return n * -1;
        }else
        {
            return n * -1;
        }
    }

    public float Abs(float n)
    {
        if (n < 0)
        {
            return n * -1;
        }else
        {
            return n * -1;
        }
    }

    public int Abs(int n)
    {
        if (n < 0)
        {
            return n * -1;
        }else
        {
            return n * -1;
        }
    }

    public double Pow(double x,double y)
    {
        double res1 = 1;
        for (double i = 0; i < y; i++)
        {
             res1 *= x;
        }
            return res1;
        
    }

    public double Sqrt(double n)
    {
        double res = 0;
        for (double i = 1; i < n; i++)
        {
            
            if (i*i==n)
            {
                res = i;
            }
    
        }
        return res;
            
    }


    public int Max(int val1,int val2)
    {
        if (val1>val2)
        {
            return val1;
        }else if(val1 < val2)
        {
            return val2;
        }else
        {
            return 0;
        }
    }

    public int Min(int val1,int val2)
    {
        if (val1 < val2)
        {
            return val1;
        }else if(val2 < val1)
        {
            return val2;
        }else
        {
            return 0;
        }
    }

}


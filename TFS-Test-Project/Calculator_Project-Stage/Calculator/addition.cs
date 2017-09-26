namespace Calculator
{
    public class addition
    {
        //add function 
        public float add(float[] x)
        {
            float sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum;
        }
    }
}

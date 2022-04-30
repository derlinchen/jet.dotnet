namespace jet.Utils
{
    public static class DbUtils
    {
        public static int CalcPageCount(int total, int pageSize)
        {
            if(total > 0)
            {
                if(total % pageSize == 0)
                {
                    return total / pageSize;
                } else
                {
                    return total / pageSize + 1;
                }
            }

            return 0;
        }
    }
}

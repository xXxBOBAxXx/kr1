string str = "\"hello\", \"2\", \"world\", \":-)\"";

string[] strs = str.Split(',');

int cntSpace = 0, cntFirstPrint = 0;

foreach (string rslt in strs)
{
    if (rslt.Length <= 5 + cntSpace)
    {
        if (cntFirstPrint == 1)
        {
            Console.Write("," + rslt);
        }
        else if (cntSpace == 1)
        {
            Console.Write(rslt.Substring(1));
        }
        else
        {
            Console.Write(rslt);
        }
        cntFirstPrint = 1;
    }
    cntSpace = 1;
}
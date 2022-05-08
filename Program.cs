string str = "\"hello\", \"2\", \"world\", \":-)\"";

string[] strs = str.Split(',');

foreach (string rslt in strs)
    if (rslt.Trim() != "")
        Console.WriteLine(rslt);
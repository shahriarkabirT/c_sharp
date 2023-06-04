int[] value = new int[5];
for (int i = 0; i < 5; i++)
{

    value[i] =Convert.ToInt32(Console.ReadLine());

}

Array.Sort(value);
foreach(int i in value)
{
    Console.Write("{0} ",i);
}




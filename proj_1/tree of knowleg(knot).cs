class knot
{
	string buff_mass, 
	string result;
	public string make_knot_left { get; set; }

	public string make_knot_right { get; set; }

	public string enter_string
	{
		get{
			return result;
		}
		set{
			result = buff_mass[i]; 
		}

	}
	public string sort_string()
	{
		string Data = "Data.txt";
		FileStream fs = new FileStream(source, FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        string[] buff_max_lengh = new string[3];
            string[] buff = null; // строковый массив для хранения данных
            while (sr.Peek() != -1)
            {
                buff[LineNumber] = sr.ReadLine();
                foreach (char c in buff[LineNumber])
                {
                    string s = " ";
                    int x = 0;
                    while (c != ' ' || c != ',' || c != '.' || c != '!' || c != '?')
                    {
                        if (x == 0)
                        {
                            s = Convert.ToString(c);
                        }
                        s = s + c;
                        x++;
                    }
                    if (x > buff_max_lengh[2].Length)
                    {
                        buff_max_lengh[2] = s;
                        if (buff_max_lengh[2].Length > buff_max_lengh[1].Length)
                        {
                            buff_max_lengh[1] = buff_max_lengh[2];
                            if (buff_max_lengh[1].Length > buff_max_lengh[0].Length)
                            {
                                buff_max_lengh[0] = buff_max_lengh[1];
                            }
                        }
                    }
                }
                Console.WriteLine("Полный путь к строке: " + MyPath + "\n\n");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Слова максимальной длины в строке:\n{0}. {1}", i, buff_max_lengh[i]);
                }
                LineNumber++;
	}
	
	void sort_string(string buff_mass,int i)
	{
		char S = " ";
		for (int j = 0; j <= buff_mass[i].lenght ; j++)
		{
			while()

		}
	}
	public override string ToString()
	{
		return "Left knot: " + make_knot_left + "Include: " +  +"\n\n\nRight knot: " + make_knot_right + ""
	}
	string make_knot_left(int i, string buff_mas,string path)
	{
	string left_value = " ";
	left_value = buff_mas[i];
	return path = path+"\left";
	}
	string make_knot_right(int i, string buff_mas,string path)
	{
	string right_value = " ";
	right_value = buff_mass[i];
	return path = path+"\right";
	}

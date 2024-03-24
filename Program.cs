class Program
{
	static int sum;

	static string userid = "";
	static string userpw = "";

	static string[] items = new string[10] { "", "", "", "", "", "", "", "", "", "" };
	static string[,] listdefault = new string[2,10] {{ "1.Flour", "2.Rice", "3.Sugar", "4.Salt", "5.Oil", "6.Powdered Milk", "7.Teabags", "8.Black pepper","9.Lentils", "10.Potatoes" },
												     {"11.Carrots","12.cheese","13.Tomatoes","14.Chicken","15.Salmon","16.Pulses","17.Bread","18.Eggs","19.Apples","20.Cucumbers"} };
	static string[,] itemprice = new string[2, 10] {{ "Rs.100/kg", "Rs.100/kg", "Rs.50/kg", "Rs.50/kg", "Rs.480/kg", "Rs.500/350gm", "Rs.250/50pcs", "Rs.50/pkt", "Rs.400/kg", "Rs.50/kg"},
												   {"Rs.60/kg", "Rs.900/kg", "Rs.75/kg", "Rs.650/kg", "Rs.300/kg", "Rs.140/kg", "Rs.60/loaf", "Rs.150/dz", "Rs.355/kg", "Rs.30/kg"}};
	static void Main(string[] args)
	{
		Console.ForegroundColor = ConsoleColor.Black;
		Console.BackgroundColor = ConsoleColor.DarkCyan;
		Console.Clear();
		userregistration();
		Console.Clear();
		userlogin();
		Console.Clear();
		mainmenu();



		static void mainmenu()
		{
			string menu_select = "";

			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear();


			Console.SetCursorPosition(42, 0);
			Console.WriteLine("GROCERY MANAGEMENT SYSTEM");
			Console.WriteLine();
			Console.WriteLine("\t\t\t\t\t\t\t\t");
			Console.SetCursorPosition(28, 2);
			for (int i = 0; i < 27; i++)
			{
				Console.Write("//");
			}

			Console.SetCursorPosition(28, 3);
			Console.WriteLine("//\t\t\t\t\t\t\t//");
			Console.SetCursorPosition(28, 4);
			Console.Write("//" + "\t\t1.View default list\t\t\t" + "//");
			Console.SetCursorPosition(28, 5);
			Console.WriteLine("//\t\t\t\t\t\t\t//");

			Console.SetCursorPosition(28, 6);
			Console.WriteLine("//");
			Console.SetCursorPosition(28, 6);
			Console.WriteLine("//" + "\t\t2.Update or Remove items form list\t" + "//");
			Console.SetCursorPosition(28, 7);
			Console.WriteLine("//\t\t\t\t\t\t\t//");

			Console.SetCursorPosition(28, 8);
			Console.WriteLine("//");
			Console.SetCursorPosition(28, 8);
			Console.Write("//" + "\t\t3.View personnal grocery list\t\t" + "//");
			Console.SetCursorPosition(28, 9);
			Console.WriteLine("//\t\t\t\t\t\t\t//");

			Console.SetCursorPosition(28, 10);
			Console.WriteLine("//");
			Console.SetCursorPosition(28, 10);
			Console.Write("//" + "\t\t4.View estimate of total shopping cost\t" + "//");
			Console.SetCursorPosition(28, 11);
			Console.WriteLine("//\t\t\t\t\t\t\t//");

			Console.WriteLine("\t\t\t\t\t\t\t\t");
			Console.SetCursorPosition(28, 12);
			for (int i = 0; i < 27; i++)
			{
				Console.Write("//");
			}

			Console.WriteLine();
			Console.SetCursorPosition(28, 14);
			Console.Write("Please enter the number of the command you want to run: ");
			menu_select = Console.ReadLine();

			if (menu_select == "1")
			{
				Console.Clear();
				defaultlist();
			}
			else if (menu_select == "2")
            {
				Console.Clear();
				UpdateAdd();
            }
			else if(menu_select == "3")
            {
				Console.Clear();
				personallist();
            }
            else if(menu_select == "")
			{
                Console.WriteLine("Invalid entry. Please try again.");
				Console.ReadLine();
				mainmenu();
            }
			else if(menu_select == "4")
            {
				Console.Clear();
				billestimate();
            }
		}



		static void userregistration()
		{
		resetregister:

			Console.SetCursorPosition(42, 0);
			Console.WriteLine("GROCERY MANAGEMENT SYSTEM");
			Console.WriteLine();
			Console.WriteLine("\t\t\t\t\t\t\t\t");
			Console.SetCursorPosition(28, 2);
			for (int i = 0; i < 27; i++)
			{
				Console.Write("//");
			}
			Console.SetCursorPosition(28, 3);
			Console.WriteLine("//\t\t\t\t\t\t\t//");
			Console.SetCursorPosition(28, 4);
			Console.Write("//" + " --User must resgister first to use application-- " + "//");
			Console.SetCursorPosition(28, 5);
			Console.WriteLine("//\t\t\t\t\t\t\t//");
			Console.SetCursorPosition(28, 6);
			for (int i = 0; i < 27; i++)
			{
				Console.Write("//");
			}
			Console.SetCursorPosition(28, 7);
			Console.Write("\t\t1.Enter Your Username:");
			Console.SetCursorPosition(63, 7);
			userid = Console.ReadLine();
			if (userid == "")
			{
				Console.SetCursorPosition(20, 9);
				Console.WriteLine("Invalid username or password. Please enter username or password again.");
				Console.SetCursorPosition(35, 10);
				Console.WriteLine("\tPress Enter to go back...");
				Console.ReadLine();
				Console.Clear();
				goto resetregister;
			}
			Console.SetCursorPosition(28, 8);
			Console.Write("\t\t2.Enter Your Password:");
			Console.SetCursorPosition(63, 8);
			userpw = Console.ReadLine();
			if (userpw == "")
			{
				Console.SetCursorPosition(20, 9);
				Console.WriteLine("Invalid username or password. Please enter username or password again.");
				Console.SetCursorPosition(35, 10);
				Console.WriteLine("\tPress Enter to go back...");
				Console.ReadLine();
				Console.Clear();
				goto resetregister;
			}
			Console.SetCursorPosition(26, 10);
			Console.Write("\t\t--Registration successful!--");
			Console.SetCursorPosition(38, 11);
			Console.WriteLine("Press Enter to continue to login...");
			Console.ReadLine();

		}



		static void userlogin()
		{
		resetlogin:

			Console.SetCursorPosition(28, 2);
			for (int i = 0; i < 27; i++)
			{
				Console.Write("//");
			}
			Console.SetCursorPosition(28, 3);
			Console.WriteLine("//\t\t\t\t\t\t\t//");
			Console.SetCursorPosition(28, 4);
			Console.Write("//\t" + "--User must Login first to use application--" + "\t//");
			Console.SetCursorPosition(28, 5);
			Console.WriteLine("//\t\t\t\t\t\t\t//");
			Console.SetCursorPosition(28, 6);
			for (int i = 0; i < 27; i++)
			{
				Console.Write("//");
			}
			Console.SetCursorPosition(28, 7);
			Console.Write("\t\t1.Enter Your Username:");
			Console.SetCursorPosition(63, 7);
			if (Console.ReadLine() != userid)
			{
				Console.SetCursorPosition(20, 9);
				Console.WriteLine("Invalid username or password. Please enter username or password again.");
				Console.SetCursorPosition(35, 10);
				Console.WriteLine("\tPress Enter to go back...");
				Console.ReadLine();
				Console.Clear();
				goto resetlogin;
			}
			Console.SetCursorPosition(28, 8);
			Console.Write("\t\t2.Enter Your Password:");
			Console.SetCursorPosition(63, 8);
			if (Console.ReadLine() != userpw)
			{
				Console.SetCursorPosition(20, 9);
				Console.WriteLine("Invalid username or password. Please enter username or password again.");
				Console.SetCursorPosition(35, 10);
				Console.WriteLine("\tPress Enter to go back...");
				Console.ReadLine();
				Console.Clear();
				goto resetlogin;
			}
			Console.SetCursorPosition(26, 10);
			Console.Write("\t\t--Registration successful!--");
			Console.SetCursorPosition(38, 11);
			Console.WriteLine("Press Enter to continue to Main Menu...");
			Console.ReadLine();
		}



		static void defaultlist()
		{
			Console.SetCursorPosition(25, 2);
			for (int i = 0; i < 27; i++)
			{
				Console.Write("//");
			}
			Console.SetCursorPosition(25, 3);
			Console.WriteLine("//\t\tDefault Grocery List");
			Console.SetCursorPosition(77, 3);
			Console.WriteLine("//");
			Console.SetCursorPosition(25, 4);
			for (int i = 0; i < 27; i++)
			{
				Console.Write("//");
			}
			Console.SetCursorPosition(36, 5);
			Console.WriteLine("//\t-Essential items-");
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Console.WriteLine("\t\t\t\t    //" + "  " + listdefault[i, j] + ": " + itemprice[i, j]);
				}
			}
			Console.SetCursorPosition(35,26);
			Console.WriteLine("---Press enter to go back to main menu---");
			Console.ReadLine();
			mainmenu();
		}

		static void UpdateAdd()
		{
			int op1 = 0;
            Console.WriteLine("\t---Enter command number you want to run---");
			Console.WriteLine("1.Update list\n2.Remove item");
			op1 = Convert.ToInt32(Console.ReadLine());
			if (op1 == 1)
			{
				string[] additems = new string[10] { "", "", "", "", "", "", "", "", "", "" };
				Console.WriteLine("\t--Enter items to Make your personal list: ");
				Console.WriteLine("*Please enter the item number before the item name");
				Console.WriteLine("*Enter 'back' when you finish adding items");
				string back = "back";
				FileStream fs = new FileStream("text.txt", FileMode.Create, FileAccess.Write);
				StreamWriter SW = new StreamWriter(fs);
				for(int i = 0;i < 10; i++)
                {
					additems[i] = Console.ReadLine();
					SW.WriteLine(additems[i]);
					if (additems[i] == "back")
                    {
						SW.Close();
						fs.Close();
						
						mainmenu();
					}
                }
			}
			else if (op1 == 2)
			{
				//removefileline.removeitem();
				//Console.ReadLine();
				//mainmenu();
			}
		}


		static void personallist()
        {
			Console.SetCursorPosition(25, 2);
			for (int i = 0; i < 27; i++)
			{
				Console.Write("//");
			}
			Console.SetCursorPosition(25, 3);
			Console.WriteLine("//\t\tView personnal list");
			Console.SetCursorPosition(77, 3);
			Console.WriteLine("//");
			Console.SetCursorPosition(25, 4);
			for (int i = 0; i < 27; i++)
			{
				Console.Write("//");
			}
			Console.SetCursorPosition(0, 5);
            Console.WriteLine("Press enter to go back");
			readfile.readlist();
			Console.ReadLine();
			mainmenu();
		}

		

		static void billestimate()
        {
			Console.SetCursorPosition(25, 2);
			for (int i = 0; i < 27; i++)
			{
				Console.Write("//");
			}
			Console.SetCursorPosition(25, 3);
			Console.WriteLine("//\t\tView bill estimate");
			Console.SetCursorPosition(77, 3);
			Console.WriteLine("//");
			Console.SetCursorPosition(25, 4);
			for (int i = 0; i < 27; i++)
			{
				Console.Write("//");
			}

			Console.SetCursorPosition(0, 7);
			Console.WriteLine("Press enter to go back");
			Console.SetCursorPosition(0, 8);
			readfile.readlist();

			Console.SetCursorPosition(0, 5);
			Console.WriteLine("Enter price of each item respectively");
			Console.SetCursorPosition(0, 6);
			Console.WriteLine("Type 0 to end adding items");
			Console.WriteLine("Type 'back' to go back");
			string opt = Console.ReadLine();
			if (opt == "back")
			{
				mainmenu();
			}


			
			int[] price = new int[100];
			for (int p = 0; p < price.Length; p++)
			{
				Console.SetCursorPosition(20, 8+p);
				price[p] = int.Parse(Console.ReadLine());
				if (price[p] == 0)
				{
					break;
				}
				sum = price.Sum();
			}
			FileStream fs = new FileStream("text.txt", FileMode.Create, FileAccess.Write);
				StreamWriter SW = new StreamWriter(fs);
				
			Console.WriteLine("Your total bill is: " + sum);
			SW.WriteLine("Your estimate bill for this month is: " + sum);
			
			opt = Console.ReadLine();
			if (opt == "back")
			{
				mainmenu();
			}
		}

	}
}


class readfile
{
	public static void readlist()
	{
		
		
			FileStream fs1 = new FileStream("text.txt", FileMode.Open, FileAccess.Read);
			StreamReader sr1 = new StreamReader(fs1);
			string str1 = sr1.ReadLine();
			while (str1 != null)
			{
				Console.WriteLine(str1);
				str1 = sr1.ReadLine();
			}
			sr1.Close();
			fs1.Close();
		
	}
}



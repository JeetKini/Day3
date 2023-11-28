using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;


namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Date and Time

            // var dateTime = new DateTime(2023,11,28);
            // Console.WriteLine(dateTime);

            //var now = DateTime.Now;
            //Console.WriteLine(now);

            //var today=DateTime.Today;
            //Console.WriteLine(today);

            //var h = 0;
            //var m = 0;
            //var s = 0;

            //for (var i = 0; i < 20; i++)
            //{
            //    TimeSpan tp = new TimeSpan(h, m, s);
            //    ++s;
            //    Thread.Sleep(1000);

            //    Console.WriteLine(tp);
            //    if (s >5) {
            //        ++m;
            //        s = 0;
            //    }
            //    if (m > 2)
            //    {
            //        ++h;
            //        m = 0;
            //    }
            //var v = TimeSpan.FromHours(1);
            //Console.WriteLine(v);

            //string name = "jeet kini";
            //Console.WriteLine(name);
            //Console.WriteLine(name.Trim());
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());
            //var split =name.Split(' ');
            //Console.WriteLine(split[0]);
            //Console.WriteLine(split[1]);
            //Console.WriteLine(name.Substring(0,name.Length));
            //Console.WriteLine(name.Substring(0));

            //console.writeline(name.replace('j', 'g'));

            //var sb = new StringBuilder("Jeet");
            //sb.Append("Kini");
            //Console.WriteLine(sb);
            //sb.Insert(4,'R');
            //Console.WriteLine(sb);
            //sb.Remove(4,1);
            //Console.WriteLine(sb  );
            //sb.Replace('J', 'G');
            //Console.WriteLine(sb);
            //Console.WriteLine(sb[5]);
            //sb.Clear();
            //Console.WriteLine(sb);

            //var v = "5-6-7-8";
            //var s = v.Split('-');
            //bool flag = false;
            //for (var i = 1; i < s.Length; i++)
            //{
            //    if (s[i]!= s[i-1]+1)
            //    {
            //        flag = true;
            //        break;
            //    }

            //}
            //if (flag)
            //{
            //    Console.WriteLine("Consecutive");
            //}
            //else {
            //    Console.WriteLine("Not");
            //}

            //var s =Console.ReadLine();
            //var l=new List<string>();
            //var ll=new List<string>();
            //Boolean flag = false;
            //var s1=s.Split(' ');



            //if (String.IsNullOrWhiteSpace(s))
            //    return;
            //foreach (var item in l)
            //{
            //    l.Add(s);
            //}
            //foreach (var item in ll)
            //{
            //    if (!ll.Contains(item))
            //    {
            //        ll.Add(item);
            //    }
            //    else
            //    {
            //        flag = true;
            //        break;
            //    }
            //}
            //if(flag)
            //{
            //    Console.WriteLine("Duplicates");
            //}
            //    Console.Write("Enter numbers ");
            //    var input = Console.ReadLine();

            //    if (String.IsNullOrWhiteSpace(input))
            //        return;

            //    var numbers = new List<int>();
            //    foreach (var number in input.Split('-'))
            //        numbers.Add(Convert.ToInt32(number));

            //    var uniques = new List<int>();
            //    var includesDuplicates = false;
            //    foreach (var number in numbers)
            //    {
            //        if (!uniques.Contains(number))
            //            uniques.Add(number);
            //        else
            //        {
            //            includesDuplicates = true;
            //            break;
            //        }
            //    }

            //    if (includesDuplicates)
            //        Console.WriteLine("Duplicate");
            //}

            //Time:
            //var user =Console.ReadLine();
            //var s = user.Split(':');
            //int h = Convert.ToInt32(s[0]);  
            //int sec = Convert.ToInt32(s[1]);
            //if (h <= 24 || sec <= 60)
            //{
            //    Console.WriteLine("OK");
            //}
            //else {
            //    Console.WriteLine("Invalid");
            //}

            //PascalCase:

            //var user = Console.ReadLine();
            //var s = user.Split(' ');
            //String[] st = new string[s.Length]; 

            //for (var i = 0; i < s.Length; i++)
            //{
            //    st[i]= s[i].Substring(0,s.Length-1).ToUpper();

            //    Console.Write(st[i] + s[i].Substring(1) );

            //}

            //count vowels
            //Console.WriteLine("Enter the name");
            //string user = Console.ReadLine();
            //Console.WriteLine(count(user));

            //File.Copy(@"C:\\Users\\hp\\Desktop\\input.txt", @"C:\\Users\\hp\\Desktop\\output22.txt");
            //Console.WriteLine("Done");

            var path = @"C:\\Users\\hp\\Desktop\\input.txt";
            //File.Delete(path);
            //Console.WriteLine("Deleted");

            //if (File.Exists(path)) {
            //    Console.WriteLine("YES");
            //}

            //var Read= File.ReadAllText(path);
            // Console.WriteLine(Read);
            //File.Move(path, @"C:\\Users\\hp\\Desktop\\output2.txt");
            //Console.WriteLine("Moved");

            //var get= File.GetAttributes(@"C:\\Users\\hp\\Desktop\\output2.txt");
            // Console.WriteLine(get);

            //FileInfo fi = new FileInfo(@"C:\\Users\\hp\\Desktop\\output2.txt");
            //fi.Encrypt();

            //Console.WriteLine("Done");

            //Directory.CreateDirectory(path);
            //Console.WriteLine("Created");

            //var files  = Directory.GetFiles(@"C:\\Program Files (x86)\\Microsoft Visual Studio\\Installer");
            //foreach (var v in files)
            //{
            //    Console.WriteLine(v);
            //}


            //var p =Path.GetFileName(path);
            // Console.WriteLine(p);
            // var p1=Path.GetExtension(path);
            // Console.WriteLine(p1); 
            // var p2=Path.GetDirectoryName(path);
            // Console.WriteLine(p2);
            // var p3=Path.GetTempPath();
            // Console.WriteLine(p3);
            // var p4=Path.GetTempFileName();
            // Console.WriteLine(p4);

           
            //WAP read text and display number of words.
            //var Read = File.ReadAllText(@"C:\\Users\\hp\\Desktop\\output2.txt");
            //Read.Trim();
            //var s = Read.Split(' ');
            //int count = 0;
            //foreach (var f in s)
            //{
            //    count++;
            //}
            //Console.WriteLine(count);

            //WAP to  Find longest word in file.
            //var Read = File.ReadAllText(@"C:\\Users\\hp\\Desktop\\output2.txt");
            //Read.Trim();
            //var s = Read.Split(' ');
            //string lon = "";
            //int length = 0;
            //for (var i = 0; i < s.Length; i++)
            //{

            //    if (s[i].Length>length)
            //    {
            //        lon = s[i];
            //    }
            //}
            //Console.WriteLine(lon);






        }
        public static int count(string user)
        {
            int count = 0;
            for (int i = 0; i < user.Length; i++)
            {
                if (user[i].Equals('a') || user[i].Equals('e') || user[i].Equals('i') || user[i].Equals('o') || user[i].Equals('u'))
                {
                    count++;
                }
            }
            return count;
        }





    }
}
    


using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System;
using System.IO;
using System.Collections.Generic;

namespace Lab06Lib
{

    public class Rootobject
    {
        public List<PolliceDepartmentID> Property1 { get; set; }
    }

    public class PolliceDepartmentID
    {

        public string id { get; set; }
        public string name { get; set; }

        public PolliceDepartmentID()
        {

        }
        public PolliceDepartmentID (string name, string id)
        {
            this.name = name;
            this.id = id;
        }
    }
    public class Func
    {
        public void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Input commands in English");
            Console.WriteLine("Commands: ");
            Console.WriteLine("'e' - exit          \t\t'a' - add record "); 
            Console.WriteLine("'d' - delete record\t\t'p' - print all records");
            Console.WriteLine("'c' - change record\t\t'f' - find record ");
            Console.WriteLine("'s' - save record as a text file");
            Console.WriteLine("Input command: ");
        }
        public int HandleInput(string input, List<PolliceDepartmentID> list, DataContractJsonSerializer serializer)
        {
            int exit = 0;
            //saves the file and exits the app 
            if(input.ToLower() == "e")
            {
                Stream fs = new FileStream("PoliceDepartment.json", FileMode.Create);
                serializer.WriteObject(fs, list);
                Console.WriteLine("File saved");
                exit = 1;
            }
            //adds department object to the collection
            if(input.ToLower() == "a")
            {
                Console.WriteLine("Input Name of department: ");
                string name = Console.ReadLine();
                Console.WriteLine("Input Id of department: ");
                string id = Console.ReadLine();
                PolliceDepartmentID newDep = new PolliceDepartmentID(name, id);
                list.Add(newDep);
            }
            //removes department object from the collection
            if (input.ToLower() == "d")
            {
                int index = 0;
                Console.WriteLine("Input currency index [max = {0}] : ", list.Count);
                index = int.Parse(Console.ReadLine());
                list.RemoveAt(index);
            }
            //prints all department objects
            if (input.ToLower() == "p")
            {
                int index = 0;
                foreach (PolliceDepartmentID p in list)
                {
                    Console.WriteLine("[{0}]\t Имя : {1, -20},\t\tID : {2, -20}",index , p.name, p.id);
                    index++;
                }
                Console.WriteLine();
            }
            //Changes department object at the specified index
            if (input.ToLower() == "c")
            {
                int index;
                string name = "";
                string id = "";
                for (; ; )
                {
                    Console.WriteLine("Input currency index [max = {0}] : ",list.Count);
                    if (int.TryParse(Console.ReadLine(), out index)&&index<=list.Count)
                        break;
                }
                    Console.WriteLine("Input Name of department: ");
                    list[index].name = Console.ReadLine();
                    Console.WriteLine("Input Id of department: ");
                    list[index].id = Console.ReadLine();
            }
            //searches the collection by specified field
            if (input.ToLower() == "f")
            {
                string ask = "";
                Console.WriteLine("Input '1' to seatch by currency code or '2' to search by it's value:");
                ask = Console.ReadLine();
                if (ask == "1")
                {
                    string name;
                    for (; ; )
                    {
                        Console.WriteLine("Input name search");
                        name = Console.ReadLine();
                        if (name.Length == 3)
                            break;
                    }
                    int index = 0;
                    foreach (PolliceDepartmentID elem in list)
                    {
                        if (elem.name == name)
                        {
                            Console.WriteLine($"Item found at index {index}");
                            break;
                        }
                        index++;
                    }
                    if (index == list.Count && list[index - 1].name != name)
                        Console.WriteLine("There is no such element in collection");
                }
                if (ask == "2")
                {
                    string idCheck;
                    for (; ; )
                    {
                        Console.WriteLine("Input search id ");
                    }
                    int index = 0;
                    foreach (PolliceDepartmentID elem in list)
                    {
                        if (elem.id == idCheck)
                        {
                            Console.WriteLine($"Item found at index {index}");
                            break;
                        }
                        index++;
                    }
                    if (index == list.Count && list[index - 1].id != idCheck)
                        Console.WriteLine("There is no such element in collection");
                }
            }
            //saves a txt file with cillection info
            if (input.ToLower() == "s")
            {
                Console.WriteLine("Input save path or onput 'i' to save in default folder:");
                string path = Console.ReadLine();
                if (path == "i")
                {
                    string res = "";
                    foreach (PolliceDepartmentID elem in list)
                    {
                        res += $"{elem.name} : {elem.id}";
                        res += "\n";
                    }
                    res = res.Trim();
                    File.WriteAllText("text.txt", res);
                    Console.WriteLine("File saved");
                }
                else
                {
                    try
                    {
                        string res = "";
                        FileInfo test = new FileInfo(path);
                        foreach (PolliceDepartmentID elem in list)
                        {
                            res += $"{elem.name} : {elem.id}";
                            res += "\n";
                        }
                        res = res.Trim();
                        if (!path.Contains(".txt"))
                            path += "/text.txt";
                        File.WriteAllText(path, res);
                        Console.WriteLine("File saved");
                    }
                    catch
                    {
                        Console.WriteLine("Unable to access folder");
                    }
                }
            }
            return exit;
        }
    }
}

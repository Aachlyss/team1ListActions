using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "add":
                        nums.Add(int.Parse(cmd[1]));
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                   case "delete":
                        if (nums.Contains(command[1]))
                        {
                            nums.Remove(command[1]);
                        }
                        //DUSHI KURO
                            break;
                    case "remove":
                        var index = int.Parse(cmd[1]);
                        nums.RemoveAt(index);
                        break;
                    case "addMany":
                        index = int.Parse(cmd[1]);
                        for (int i = cmd.Count() - 1; i >= 2; i--)
                        {
                            nums.Insert(index, int.Parse(cmd[i]));
                        }
                        break;
                        //vzdgdzvbcbkjckjcd
                    //TODO
                    case "print":
                        Console.WriteLine(string.Join(' ', nums));
                        break;
                    case "printodds":
                        Console.WriteLine(string.Join(' ', nums.Where(x => x % 2 != 0)));
                        break;
                    default:
                        break;
                }
            }

        }
    }
}

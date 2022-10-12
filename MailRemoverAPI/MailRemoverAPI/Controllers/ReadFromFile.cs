using System;
using System.IO;

namespace MailRemoverAPI.Controllers;

class ReadFromFile
{
     static void FileReader()
    {
        // The path of the .txt file where the information
        // of user will be kept and saved for calculations of emission.
        string filePath = @"C:\Users\Desktop\file.txt";

        //Today's date to check the emission for today
        DateTime thisDay = DateTime.Today;
        
        // Counting all the lines of the file
        var lineCount = File.ReadAllLines(filePath).Length;

        // Calculates all of the letters' emission.
        int allLettersEmission = 50 * lineCount;
    
        //
        List<string> lines = new List<string>();
        List<Email> emails = new List<Email>();

        lines = File.ReadAllLines(filePath).ToList();

        int count = 0;

        foreach (string line in lines)
        {
            // Shows that every item is splitted by ','
            string [] items  = line.Split(',');
            Email e = new Email(items[0], items[1]);

            // Converting string to DateTime
            DateTime emailDate = DateTime.Parse(e.dateOfEmail);

            // Comparing the today's date an email's date and counting
            // how much emails deleted today
            
            if (DateTime.Compare(thisDay, emailDate) == 0)
            {
                count += 1;
            }
            else {break;}
        }

        // Counting today's letters emission
        int todayLettersEmission = 50 * count;

        // Each line will be wrote to the same .txt file
        /*foreach(String line in lines)
        {
            Console.Writeline(line);
        }*/

    }
}
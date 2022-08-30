//Commented code for testing UI on MacOS

using System.Reflection.Emit;
using System.Data;
//using Internal;
using System;  
using System.Collections.Generic;  
using System.Collections.ObjectModel;  
using System.IO;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
//using System.Management.Automation;

namespace isbtddotnetconig

{
    class datacollection
    {
        static void Main(string[] args)
        {  
            string configversion = "prebuild";
            //blank lines for ease of viewing
            Console.WriteLine(@"-Thank you for using the ISBTD Windows Configurator. Version {0}", configversion);

            Console.WriteLine(" ");
            Console.WriteLine(@"-What is this PC's password? Needed for sudo commands");
            //sudopswrd is the password to be used for sudo commands
            string sudopswrd = Console.ReadLine();


            //for windows
            //string apprepo = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            Console.WriteLine(" ");
            Console.WriteLine(@"-What is the directory for the USB Drive? In Format of  C:\Drivepath");
            string apprepo = Console.ReadLine();
            
            
            

            //Confirmation
            Console.WriteLine(" ");
            Console.WriteLine("-Recorded Sudo Password was {0}", sudopswrd);
            Console.WriteLine("-Recorded directory for USB Drive was {0}", apprepo);


            Console.WriteLine(" ");
	        Console.WriteLine("Was this correct? true or false?");
            bool usrconf = bool.Parse(Console.ReadLine());
                if(usrconf == true)
	                {
	                    //confirmed yes, in this space script for installing
                        Console.WriteLine("This function hasn't been made yet");
                        Environment.Exit(0);
                    }
                else if(usrconf == false)
                    {
                        Console.WriteLine("You answered no, thanks for using the ISBTD Windows Configurator. Version {0}", configversion);
                    }
                else
                    {
                        Console.WriteLine("Error. Exception reached, usrconf was not true or false.");
                        Console.WriteLine("Do you want to try again? true or false?");
                        bool usrconftryagain = bool.Parse(Console.ReadLine());
                        if(usrconftryagain == true)
                            {
                                Console.WriteLine("Sorry, this feature isn't available yet.");
                            }
                        else
                            if(usrconftryagain == false)
                                {
                                    Console.WriteLine("The program will exit now");
                                    Environment.Exit(0);
                                }
                            else
                                {
                                    Console.WriteLine("Sorry, an exception occurred. The program will exit");
                                    Environment.Exit(0);
                                }
                    }


        }
    }


// Following code credit  Saurabh Rai
// https://www.c-sharpcorner.com/article/silent-installation-of-applications-using-C-Sharp/
  
/*
    class Program  
    {  
        static void Main(string[] args)  
      {  
            ProcessFolder();  
        }  
  
        private static void ProcessFolder()   
      {  
            const string SOURCEFOLDERPATH = @ "applicationrepository";
  
            if (Directory.Exists(SOURCEFOLDERPATH)) {  
                Console.WriteLine("Directory exists at: {0}", SOURCEFOLDERPATH);  
                if (Directory.GetFiles(SOURCEFOLDERPATH, "*.exe").Length > 0) {  
                    int count = Directory.GetFiles(SOURCEFOLDERPATH, "*.exe").Length;  
                    string[] files = Directory.GetFiles(SOURCEFOLDERPATH, "*.exe");  
  
                    foreach(var file in files) {  
                        var fileName = System.IO.Path.GetFileName(file);  
                        var fileNameWithPath = SOURCEFOLDERPATH + "\\" + fileName;  
                        Console.WriteLine("File Name: {0}", fileName);  
                        Console.WriteLine("File name with path : {0}", fileNameWithPath);  
                        //Deploy application  
                        Console.WriteLine("Wanna install {0} application on this VM?   
                            Press any key to contiune.  
                            ", fileName);  
                            Console.ReadKey(); DeployApplications(fileNameWithPath); Console.ReadLine();  
                        }  
                    }  
  
                } else  
                    Console.WriteLine("Directory does not exist at: {0}", SOURCEFOLDERPATH);  
  
            }  
  
  
            public static void DeployApplications(string executableFilePath)  
      {  
                PowerShell powerShell = null;  
                Console.WriteLine(" ");  
                Console.WriteLine("Deploying application...");  
                try {  
                    using(powerShell = PowerShell.Create())  
                    {  
                        //here “executableFilePath” need to use in place of “  
                        //'C:\\ApplicationRepository\\FileZilla_3.14.1_win64-setup.exe'”  
                        //but I am using the path directly in the script.  
                        powerShell.AddScript("$setup=Start-Process 'C:\\ApplicationRepository\\  
                            FileZilla_3 .14 .1 _win64 - setup.exe ' -ArgumentList ' / S ' -Wait -PassThru");  
  
                            Collection < PSObject > PSOutput = powerShell.Invoke(); foreach(PSObject outputItem in PSOutput) {  
  
                                if (outputItem != null)  
                                {  
  
                                    Console.WriteLine(outputItem.BaseObject.GetType().FullName);  
                                    Console.WriteLine(outputItem.BaseObject.ToString() + "\n");  
                                }  
                            }  
  
                            if (powerShell.Streams.Error.Count > 0)  
                            {  
                                string temp = powerShell.Streams.Error.First().ToString();  
                                Console.WriteLine("Error: {0}", temp);  
  
                            } else  
                                Console.WriteLine("Installation has completed successfully.");  
  
                        }  
                    }  
                    catch (Exception ex)  
                    {  
                        Console.WriteLine("Error occured: {0}", ex.InnerException);  
                        //throw;  
                    } finally  
                    {  
                        if (powerShell != null)  
                            powerShell.Dispose();  
                    }  
  
                }  
            }  
        }  
        */
    class exit
    {
        static void Exit(string[] args)
        {
            //Code for end of program
            Console.WriteLine("Thank you for using the ISBTD Windows Configurator");
            Environment.Exit(0);
        }
    }
}

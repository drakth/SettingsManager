using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Date of creation: November 11th of 2021.
//Description: Small, quick utility to store and retrieve program settings.
//Creator: Matias A. Villagarcia.

//********************************************** Change history **********************************************
//**
//Date: 11/11/2021, Initial Version, Matias A. Villagarcia
//Date: 14/11/2021, Updated comments and renamed some methods to english to maintain consistency
//**
//************************************************************************************************************

namespace SettingsManager
{
    public class clSettingsManager
    {
        //We store all settings in memory in this dictonary.
        //We need to save them to disk using saveSettings method or they will be lost
        //when the program terminates.
        Dictionary<string, string> settings = new Dictionary<string, string>();

        private void saveLog(string log)
        {
            //Simple error logger...
            try
            {
                StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\error_log_settingManager.txt", true);
                sw.WriteLine( DateTime.Now.ToString() + " - " + log);
                sw.Close();
            }
            catch(Exception ex)
            {
                //welp... hopejfully this never happens D:
            }
        }

        public bool createDefaultFile()
        {
            //Create an empty config file only if it doesnt exists already.
            //This method should be call the first time we want to create en empty settings file.
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\settings.cfg") == false)
                {
                    StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\settings.cfg");
                    sw.Close();
                    return true;
                }
            }
            catch(Exception ex)
            {
                saveLog(ex.Message);
                return false;
            }
            return false;
        }

        public bool checkDefaultFile()
        {
            //Checks for the existance of the default settings file.
            //This method should be used to check if the settings file exists, in order to
            //create it with the createDefaultFile method.
            try
            {
                if(File.Exists(Environment.CurrentDirectory+ "\\settings.cfg")==false)
                {
                    return false;
                }else
                {
                    return true;
                }
            }catch(Exception ex)
            {
                saveLog(ex.Message);
                return false;
            }
        }

        public bool loadFile()
        {
            //Load settings in the config file to memory.
            //Unless its the first run and no settings file exists, we should always do this first.
            try
            {
                if(File.Exists(Environment.CurrentDirectory + "\\settings.cfg")== true)
                {
                    StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\settings.cfg");
                    while (sr.EndOfStream != true)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(',');
                        if (settings.ContainsKey(values[0].ToString()) == false)
                        {
                            settings.Add(values[0], values[1]);
                        }
                    }
                    sr.Close();
                    return true;
                }else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                saveLog(ex.Message);
                return false;
            }
        }

        public bool createSetting(string name, string value)
        {
            //Create a new setting and its corresponding value only if the key does not exists.
            //This method saves the settings to memory only, in other to be permanent 
            //we need to save the settings to disk with saveSettings method.
            try
            {
                if(File.Exists(Environment.CurrentDirectory + "\\settings.cfg")==true)
                {
                    if(settings.ContainsKey(name)==false)
                    {
                        settings.Add(name, value);
                        return true;
                    }
                }else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                saveLog(ex.Message);
                return false;
            }
            return false;
        }

        public bool updateSetting(string name, string value)
        {
            //Update the value of a setting.
            //This method updates the settings to memory only, in other to be permanent 
            //we need to save the settings to disk with saveSettings method.
            try
            {
                if(File.Exists(Environment.CurrentDirectory + "\\settings.cfg")==true)
                {
                    if(settings.ContainsKey(name)==true)
                    {
                        settings[name] = value;
                        return true;
                    }
                }
            }catch(Exception ex)
            {
                saveLog(ex.Message);
                return false;
            }
            return false;
        }

        public bool deleteSetting(string name)
        {
            //Delete a setting from memory, you will need to save the changes to make this permanent.
            try
            {
                if(File.Exists(Environment.CurrentDirectory + "\\settings.cfg")==true)
                {
                    if(settings.ContainsKey(name)==true)
                    {
                        return settings.Remove(name);
                    }
                }
            }catch(Exception ex)
            {
                saveLog(ex.Message);
                return false;
            }
            return false;
        }

        public string readSetting(string name)
        {
            //Read a stored setting from memory.
            try
            {
                if(File.Exists(Environment.CurrentDirectory + "\\settings.cfg")==true)
                {
                    if(settings.ContainsKey(name)==true)
                    {
                        return settings[name];
                    }
                }
            }catch(Exception ex)
            {
                saveLog(ex.Message);
                return "";
            }
            return "";
        }

        public bool saveSettings()
        {
            //Save the settings from memory to file.
            //We use this method to save the settings stored in memory to the settings file.
            try
            {
                if(File.Exists(Environment.CurrentDirectory + "\\settings.cfg")==true)
                {
                    StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\settings.cfg");
                    foreach( KeyValuePair<string, string> data in settings)
                    {
                        string dataToSave = data.Key + "," + data.Value;
                        sw.WriteLine(dataToSave);
                    }
                    sw.Close();
                    return true;
                }
            }catch(Exception ex)
            {
                saveLog(ex.Message);
                return false;
            }
            return false;
        }

        public bool existsSetting(string name)
        {
            //Check if a setting exists.
            try
            {
                if(File.Exists(Environment.CurrentDirectory + "\\settings.cfg")==true)
                {
                    if(settings.ContainsKey(name)==true)
                    {
                        return true;
                    }else
                    {
                        return false;
                    }
                }
            }catch(Exception ex)
            {
                saveLog(ex.Message);
                return false;
            }
            return false;
        }
    }
}
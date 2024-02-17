using System;
namespace CPSC3130_Project
{
	public class FileProcess
	{
		String _file = "";
		public FileProcess(){}
        //Method read the FileName parameter and return a Type List arrayData value.
		public List<String[]> ReadFile (String fileName)
		{
            List<String[]> arrayData = new List<String[]>();
            StreamReader read = new StreamReader(fileName);
            while (!read.EndOfStream)
            {
                //Read line
                string line = read.ReadLine();
                //Seperate the element by comma and put in the array.
                string[] array = line.Split(',');
                //Add array to List element.
                arrayData.Add(array);
            }
            read.Close();
            return arrayData;
        }
        //Method Write the Type List arrayData parameter to FileName parameter 
        public void WriteFile (List<String[]> arrayData, String fileName)
        {
            StreamWriter write = new StreamWriter(fileName,append:true);            
            for (int i = 0; i < arrayData.Count; i++)
            {
                write.WriteLine(string.Join(",", arrayData[i]));
            }
            write.Close();  
        }
    }
}


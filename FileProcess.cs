using System;
namespace CPSC3130_Project
{
    //This Class for File Processing
    //Provide Get Data from file, Write Data to File
	public class FileProcess
	{
        List<String[]> _arrayData = new List<String[]>();
        String _file = "";
		public FileProcess()
        {
        }

        //Method Get Data from file. Return Data in List
        public List<String[]> GetArrayData(String fileName)
        {
            StreamReader read = new StreamReader(fileName);
            while (!read.EndOfStream)
            {
                //Read line
                string line = read.ReadLine();
                //Seperate the element by comma and put in the array.
                string[] array = line.Split(',');
                //Add array to List element.
                _arrayData.Add(array);
            }
            read.Close();
            return _arrayData;
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

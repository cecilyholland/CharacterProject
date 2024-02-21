namespace CPSC3130_Project
{
    //This Class for File Processing
    //Provide Get Data from file, Write Data to File
	public class FileProcess
	{        
		public FileProcess()
        {
        }

        //Method Get Data from file. Return Data in User Data List
        public List<String[]> GetArrayData(String fileName)
        {
            StreamReader read = new StreamReader(fileName);
            List<String[]> _arrayData = new List<String[]>();
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

        //Method Get Data from file. Return Data in Character List
        public List<String[]> GetCharData(String fileName)
        {
            StreamReader read = new StreamReader(fileName);
            List<String[]> _charData = new List<String[]>();
            while (!read.EndOfStream)
            {
                //Read line
                string line = read.ReadLine();
                //Seperate the element by comma and put in the array.
                string[] array = line.Split(',');
                //Add array to List element.
                _charData.Add(array);
            }
            read.Close();
            return _charData;
        }

        //Method Write the Type List of String in ARRAY Data parameter to FileName parameter 
        public void WriteFile (List<String[]> arrayData, String fileName)
        {
            StreamWriter write = new StreamWriter(fileName,append:true);            
            for (int i = 0; i < arrayData.Count; i++)
            {
                write.WriteLine(string.Join(",", arrayData[i]));
            }
            write.Close();  
        }

        //Method Write the List of String Data parameter to FileName parameter
        //Not use yet.
        public void WriteFile(Dictionary<String,int> dictionaryData, String fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);
            for (int j = 0; j < dictionaryData.Count; j++)
            {
                writer.WriteLine($"{dictionaryData.ElementAt(j).Key},{dictionaryData.ElementAt(j).Value}");
            }
            writer.Close();
        }
    }
}

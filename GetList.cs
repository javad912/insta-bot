using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramBot
{
    public class GetList
    {
        public string GetCustumList(Label label)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    //get the file
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                      
                        label.Text = filePath;
                       return fileContent = streamReader.ReadToEnd();

                    }

                }
                else
                {
                    label.Text = "No Files Selected !";
                    return ""; 
                }





            }



        }
    }
}

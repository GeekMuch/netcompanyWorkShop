using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Letter_Distributor_Client
{
    class FileLoader
    {
        private byte[] selectedFile;
        private string filepath;

        public void SelectFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                if (IsNoFileSelected(openFileDialog))
                {
                    return;
                }

                filepath = openFileDialog.FileName;

                Stream fileStream = openFileDialog.OpenFile();
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    selectedFile = binaryReader.ReadBytes((int)fileStream.Length);
                }
            }
        }

        private static bool IsNoFileSelected(OpenFileDialog openFileDialog)
        {
            return openFileDialog.FileName == "";
        }

        public string GetFileAsBase64String()
        {
            return Convert.ToBase64String(selectedFile);
        }

        public string getFilePath()
        {
            return filepath;
        }

        
    }
}

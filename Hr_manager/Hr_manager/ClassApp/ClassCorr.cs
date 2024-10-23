using Hr_manager.ADOApp;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Hr_manager.ClassApp
{
    public class ClassCorr
    {
        public static Worker CorrUser { get; set; }
        public static byte[] getPhoto()
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                
                    var answer = File.ReadAllBytes(dialog.FileName);
                    return answer;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return null;
            }
        }
    }
    
}

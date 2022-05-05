using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using ExcelDataReader;
using Microsoft.AspNetCore.Http;
using Microsoft.Office.Interop.Excel;

namespace DAL
{
    public class UploadFileRepository : IFileOperation<UpdateFile>
    {

 
        public  List<UpdateFile> GetData()
        {
            try
            {

                string[] allfiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.xlsx*", SearchOption.AllDirectories);
                IExcelDataReader reader = null;
                int count = 0;
                List<UpdateFile> excelData = new List<UpdateFile>();
                using (FileStream stream = File.Open(allfiles[0], FileMode.Open))
                {
                    reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    while (reader.Read())
                    {
                        if (count >= 1)
                        {
                            excelData.Add(new UpdateFile()
                            {
                                Discount = Convert.ToDouble(reader.GetValue(0)),
                                PhrItem = Convert.ToDouble(reader.GetValue(2)),
                                SellerId = Convert.ToDouble(reader.GetValue(3).ToString()),
                            });
                        }
                        count++;
                    }
                }
                            
                return excelData;
            }
            catch(Exception e)
            {
                return null;
            }

        }

        public bool Save(IFormFile file,string path)
        {
            try
            {
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory() + "\\wwwroot", @"\\Uploads");
                string fullPath = Path.Combine(path, file.FileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

       
    }
}

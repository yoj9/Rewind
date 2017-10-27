using Rewind.Models.ViewModel;
using Rewind.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Rewind.Models.EntityManager
{
    public class FileUploadManager
    {
        public void fileUpload(FileUploadViewModel fileVM, HttpPostedFileBase postedFile)
        {
            using (ImageBrowserEntities db = new ImageBrowserEntities())
            {
                //Preparation of image
                //incoming image to Converting into byte
                byte[] bytes;
                using (BinaryReader br = new BinaryReader(postedFile.InputStream))
                {
                    bytes = br.ReadBytes(postedFile.ContentLength);
                }

                //Creating obj for FileUploader
                FileUploader fileUploadEntityObj = new FileUploader();

                //assigning to database entity
                fileUploadEntityObj.filename = fileVM.file_filename;
                fileUploadEntityObj.filedata = bytes;
                fileUploadEntityObj.uploadtime = fileVM.file_uploaddate;
                fileUploadEntityObj.location = fileVM.file_location;
                fileUploadEntityObj.regisid = 1;

                db.FileUploaders.Add(fileUploadEntityObj);
                db.SaveChanges();
            }
        }


        public static List<FileUploadViewModel> GetFiles()
        {
            List<FileUploadViewModel> files = new List<FileUploadViewModel>();
            using (ImageBrowserEntities db = new ImageBrowserEntities())
            {
                foreach(var record in db.FileUploaders)
                {
                    files.Add(new FileUploadViewModel
                    {
                        file_id = record.id,
                       file_filename  = (record.filename)

                    });
                }
            }
            return files;
        }

        public dynamic Download(int? f_id)
        {
            //byte[] bytes;
            //string fileName, contentType;

            using (ImageBrowserEntities db = new ImageBrowserEntities())
            {
               var  fileRecord = db.FileUploaders.Where(o => o.id.Equals(f_id)).Select(u => u.filedata);


                return fileRecord;
            }
            //string constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        cmd.CommandText = "SELECT Name, Data, ContentType FROM tblFiles WHERE Id=@Id";
            //        cmd.Parameters.AddWithValue("@Id", fileId);
            //        cmd.Connection = con;
            //        con.Open();
            //        using (SqlDataReader sdr = cmd.ExecuteReader())
            //        {
            //            sdr.Read();
            //            bytes = (byte[])sdr["Data"];
            //            contentType = sdr["ContentType"].ToString();
            //            fileName = sdr["Name"].ToString();
            //        }
            //        con.Close();
            //    }
            //}

            //return File(bytes, contentType, fileName);

        }

    }
}
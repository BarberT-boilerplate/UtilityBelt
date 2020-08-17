using System;
using System.IO;

namespace UtilityBeltCore
{
    public class FileManager
    {
        public static bool MoveFileToAppFolder(string oldPath, string newPath)
        {
            bool success = false;
            try
            {
                FileInfo file = new FileInfo(newPath);
                // If the directory exists, this call does nothing
                file.Directory.Create();

                if (!File.Exists(oldPath))
                {
                    // This statement ensures that the file is created, 
                    // but the handle is not kept. 
                    using (FileStream fs = File.Create(oldPath)) { }
                }

                // Ensure that the target does not exist. 
                if (File.Exists(newPath)) File.Delete(newPath);

                // Move the file.
                File.Move(oldPath, newPath);

                // See if the original exists now. 
                if (File.Exists(oldPath))
                {
                    Exception ex = new Exception("The original file still exists, which is unexpected.");
                    string ClassName = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName;
                    string MethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    //Log.Fatal(ex, String.Format("{0} | {1}", ClassName, MethodName));
                    throw ex;
                }
                else
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                string ClassName = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName;
                string MethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                //Log.Fatal(ex, String.Format("{0} | {1}", ClassName, MethodName));
            }
            return success;
        }
    }
}

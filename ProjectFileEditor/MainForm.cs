using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFileEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenProjectFiles_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSolutionDirectoryPath.Text))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(txtSolutionDirectoryPath.Text);

                string[] extensions = { "*.csproj", "*.vbproj", "packages.config", "web.config"/*, "AssemblyInfo.cs"*/ };

                IEnumerable<string> files = extensions.SelectMany(filter => Directory.EnumerateFiles(dirInfo.FullName, filter, SearchOption.AllDirectories));
                foreach (string file in files)
                {
                    Process p = new Process();
                    //p.StartInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Notepad++\notepad++.exe", file);
                    p.StartInfo = new ProcessStartInfo(@"C:\Program Files\Notepad++\notepad++.exe", file);
                    
                    p.Start();

                }
            }

        }

        private List<FileInfo> GetFilesInDirectory(DirectoryInfo subDirINfo, string filter)
        {
            List<FileInfo> files = new List<FileInfo>();
            files.AddRange(subDirINfo.GetFiles(filter).ToList());
            foreach (DirectoryInfo directory in subDirINfo.GetDirectories())
            {
                files.AddRange(GetFilesInDirectory(directory, filter));
            }
            return files;

        }

        private void btnBrowseSolutionDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbdlg = new FolderBrowserDialog())
            {
                if (fbdlg.ShowDialog() == DialogResult.OK)
                {
                    txtSolutionDirectoryPath.Text = fbdlg.SelectedPath;
                }
            }
        }

        private void btnCopyLibs_Click(object sender, EventArgs e)
        {
            DirectoryInfo targetDirInfo = new DirectoryInfo(textBox2.Text);
            DirectoryInfo sourceDirInfo = new DirectoryInfo(textBox1.Text);
            
            string[] extensions = { "*.dll" };
            IEnumerable<string> targetDirfiles = extensions.SelectMany(filter => Directory.EnumerateFiles(targetDirInfo.FullName, filter, SearchOption.TopDirectoryOnly));
            IEnumerable<string> soruceDirfiles = extensions.SelectMany(filter => Directory.EnumerateFiles(sourceDirInfo.FullName, filter, SearchOption.TopDirectoryOnly));
            Regex regex = new Regex(@"([\d.]+)\s+(\S+)");
            
            foreach (string file in targetDirfiles)
            {
                string searchPattern  = regex.Replace(Path.GetFileName(file), ".*");
                

                string srcFilePath = soruceDirfiles.FirstOrDefault(srcFile => Path.GetFileName(file) == Path.GetFileName(srcFile));

                if (!string.IsNullOrWhiteSpace(srcFilePath))
                {
                    File.Copy(srcFilePath, file, true);
                }


            }
        }

        private void btnCopyInfragisticsLibraries_Click(object sender, EventArgs e)
        {
            List<string> simpleBimInfragisticsLibs = Directory.GetFiles(txtSimplebimLibPath.Text, "Infragistics*.dll")
                .Select(filePath => Path.GetFileNameWithoutExtension(filePath)).ToList();


            DirectoryInfo targetDirInfo = new DirectoryInfo(txtInfragisticsSimergyLibPath.Text);
            foreach (string simplebimInfragisticsFile in simpleBimInfragisticsLibs)
            {
                //string versionedInfragisticsDllFile = ;
                //string versionFreeInfragisticsDllFile = Path.Combine(txtInfagisticsVersionFreeLibPath.Text, $"{simplebimInfragisticsFile}.dll");

                string versionedInfragisticsDllFile =  $"{simplebimInfragisticsFile}.v17.2.dll".Replace("Infragistics.", "Infragistics4.");
                string versionFreeInfragisticsDllFile =  $"{simplebimInfragisticsFile}.dll";

                if (!File.Exists(Path.Combine(txtInfagisticsVersionedLibPath.Text, versionedInfragisticsDllFile)))
                {
                    File.Copy(Path.Combine(txtInfagisticsVersionedLibPath.Text, versionedInfragisticsDllFile), Path.Combine(txtInfragisticsSimergyLibPath.Text, versionedInfragisticsDllFile), true);
                }

                if (!File.Exists(Path.Combine(txtInfagisticsVersionFreeLibPath.Text, versionFreeInfragisticsDllFile)))
                {
                    File.Copy(Path.Combine(txtInfagisticsVersionFreeLibPath.Text, versionFreeInfragisticsDllFile), Path.Combine(txtInfragisticsSimergyLibPath.Text, versionFreeInfragisticsDllFile), true);
                }


            }
        }
    }
}

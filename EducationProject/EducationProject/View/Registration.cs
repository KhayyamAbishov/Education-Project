using EducationProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationProject.View
{
    public partial class Registration : Form
    {
      static  EducationProjectDbEntities1 db = new EducationProjectDbEntities1();
        static OpenFileDialog dbxChoosePhoto = new OpenFileDialog();
        static string currFileRoot = Directory.GetCurrentDirectory();
        static string UploadFolderPath = Path.Combine(currFileRoot, "Upload");
       List<TeacherDetails> tDet = db.Teachers.Join(db.Packages, t => t.PackageId, p => p.PackageId, (t, p) => new TeacherDetails
        {
            TeacherName = t.TeacherName,
            TeacherSurname = t.TeacherSurname,
            TeacherEmail = t.TeacherEmail,
            TeacherPhone = t.TeacherPhone,
            TeacherPhoto = t.TeacherPhoto,
            TeacherBio = t.TeacherBio,
            TeacherSpeciality = p.PackageName
        }).ToList();

        public Registration()
        {
            InitializeComponent();
            Directory.CreateDirectory(UploadFolderPath);
        }

        private void btnChooseRegstrTeachPh_Click(object sender, EventArgs e)
        {

            txbRegistrTeacPhoto.Text = ChoosePhoto();
        }

        static private string ChoosePhoto()
        {
            if (dbxChoosePhoto.ShowDialog() == DialogResult.OK)
            {
                string photoFilePath = dbxChoosePhoto.FileName;
                string fileName = Path.GetFileName(photoFilePath);
                File.Copy(photoFilePath, Path.Combine(UploadFolderPath, fileName));
                return photoFilePath;
            }
            return "No photo choosen";


        }

        private void GetListTeacherSpec()
        {
            foreach (Package item in db.Packages.ToList())
            {
                cbxRegtrTeacherSpec.Items.Add(item.PackageName);
            }
        }


        private int GetTeacherSpec()
        {
            int packageId = 0;
            packageId = db.Packages.Where(s => s.PackageName == cbxRegtrTeacherSpec.SelectedItem.ToString())
                .Select(s => s.PackageId).First();

            return packageId;

        }




        private void btnRgistrAddTeach_Click(object sender, EventArgs e)
        {



            Teacher teacher = new Teacher()
            {

                TeacherName = txbRegistrTeacName.Text,
                TeacherSurname = txbRegistrTeacSurname.Text,
                TeacherEmail = txbRegistrTeacEmail.Text,
                TeacherPhone = txbRegistrTeacPhone.Text,
                TeacherBio = txbRegistrTeacBio.Text,
                TeacherPhoto = Path.Combine(@"\Upload", Path.GetFileName(dbxChoosePhoto.FileName)),
                PackageId = GetTeacherSpec(),



            };

            User user = new User()
            {
                UserPassword = txbRegistrTeacPasswrd.Text,
                UserEmail = txbRegistrTeacEmail.Text,
                UserTypeId = 1
            };

            db.Teachers.Add(teacher);
            db.Users.Add(user);
            db.SaveChanges();
        }


        private void cbxRegtrTeacherSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetListTeacherSpec();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationProjectDbDataSet2.Teacher' table. You can move, or remove it, as needed.
            //  this.teacherTableAdapter.Fill(this.educationProjectDbDataSet2.Teacher);
            GetListTeacherSpec();
        
            dgvRegistrTeacher.DataSource = tDet;
        }


        bool Update()
        {
            
        }
        private void btnRegistrUpdateTeach_Click(object sender, EventArgs e)
        {

        }

        private void dgvRegistrTeacher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRegistrTeacher.CurrentRow.Index != -1)
            {
                txbRegistrTeacName.Text = dgvRegistrTeacher.CurrentRow.Cells["TeacherName"].Value.ToString();
                txbRegistrTeacSurname.Text = dgvRegistrTeacher.CurrentRow.Cells["TeacherSurname"].Value.ToString();
                txbRegistrTeacEmail.Text = dgvRegistrTeacher.CurrentRow.Cells["TeacherEmail"].Value.ToString();
                txbRegistrTeacPhone.Text = dgvRegistrTeacher.CurrentRow.Cells["TeacherPhone"].Value.ToString();
                txbRegistrTeacBio.Text = dgvRegistrTeacher.CurrentRow.Cells["TeacherBio"].Value.ToString();


            }
        }
    }


}

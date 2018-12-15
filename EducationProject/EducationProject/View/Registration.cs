using EducationProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        EducationProjectDbEntities1 db = new EducationProjectDbEntities1();
       static OpenFileDialog dbxChoosePhoto = new OpenFileDialog();

        public Registration()
        {
            InitializeComponent();
        }

        private void btnChooseRegstrTeachPh_Click(object sender, EventArgs e)
        {
            
         txbRegistrTeacPhoto.Text = ChoosePhoto();
        }

      static  private string ChoosePhoto()
        {
            if (dbxChoosePhoto.ShowDialog()==DialogResult.OK)
            {
                string photoFilePath = dbxChoosePhoto.FileName;
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
            packageId=db.Packages.Where(s => s.PackageName == cbxRegtrTeacherSpec.SelectedItem.ToString())
                .Select(s=>s.PackageId).First();
           
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
                TeacherPhoto = dbxChoosePhoto.FileName,
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
            GetListTeacherSpec();
        }
    }
}

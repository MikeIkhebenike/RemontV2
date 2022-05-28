using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemontV2.Models;
using RemontV2.Utils;


namespace RemontV2.Views
{
    public partial class AccessoriesAddEditForm : Form
    {
        Комплектующее currentAcc = new Комплектующее();
        public AccessoriesAddEditForm()
        {
            InitializeComponent();
        }

        private void AccessoriesAddEditForm_Load(object sender, EventArgs e)
        {
            поставщикBindingSource.DataSource = DatabaseContext.db.Поставщик.ToList();
            foreach (AccessoriesCard a in AccessoriesForm.selectedAccessoriesCard)
            {
                currentAcc = DatabaseContext.db.Комплектующее.First(x => x.Наименование == a.label1.Text);
                комплектующееBindingSource.DataSource = currentAcc;
                изображениеPictureBox.ImageLocation = currentAcc.Изображение;
                //наименованиеComboBox.SelectedIndex   = currentAcc.ID_поставщика; 
            //}
            //if (currentAcc.ID_комплектующего == 0)
            //{
            //    DeleteAccBtn.Enabled = false;
                //SaveAccBtn.Visible = false;
            }
            //else
            //{
            //    SaveAccBtn2.Visible = false;
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ShutDownEMPBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveAccBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();

         
                if (string.IsNullOrWhiteSpace(currentAcc.Наименование))
                {
                    errors.AppendLine("Укажите название комплектующего");
                }
                if (string.IsNullOrWhiteSpace(currentAcc.СтоимостьШт))
                {
                    errors.AppendLine("Укажите стоимость");
                }
                if (string.IsNullOrWhiteSpace(Convert.ToString(currentAcc.ID_поставщика)))
                {
                    errors.AppendLine("Укажите поставщика");
                }
                if (string.IsNullOrWhiteSpace(currentAcc.Изображение))
                {
                    errors.AppendLine("Выберите изображение");
                }
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                    return;
                }
                if (currentAcc.ID_комплектующего == 0)
                {
                    DatabaseContext.db.Комплектующее.Add(currentAcc);
                }
                try
                {
                    DatabaseContext.db.SaveChanges();
                    MessageBox.Show("Информация сохранена");
                this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
               
            

        }

        private void DeleteAccBtn_Click(object sender, EventArgs e)
        {

        }

        private void ChoosePicBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory + @"\Accessories\";
            openFileDialog.Filter = "png files (*.png)|*png|All Files (*.*)|*.*";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                int num = file.IndexOf("Accessories");
                file = file.Substring(num);
                изображениеPictureBox.Image = Image.FromFile(file);
                currentAcc.Изображение = file;
            }
        }

        private void SaveAccBtn2_Click(object sender, EventArgs e)
        {
            currentAcc.ID_поставщика = наименованиеComboBox.SelectedIndex + 1;
            currentAcc.КоличествоВналич = Convert.ToInt32(количествоВналичTextBox.Text);
            currentAcc.Наименование = наименованиеTextBox.Text;
            currentAcc.СтоимостьШт = стоимостьШтTextBox.Text;
            currentAcc.Изображение = изображениеPictureBox.ImageLocation;

            DatabaseContext.db.Комплектующее.Add(currentAcc);
            try
            {

                DatabaseContext.db.SaveChanges();
                this.Close();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (System.Data.Entity.Validation.DbEntityValidationResult validationError in ex.EntityValidationErrors)
                {
                    MessageBox.Show("Object: " + validationError.Entry.Entity.ToString());
                    MessageBox.Show(" ");
                    foreach (System.Data.Entity.Validation.DbValidationError err in validationError.ValidationErrors)
                    {
                        MessageBox.Show(err.ErrorMessage + " ");
                    }
                }

               
            }
        }
    }
}

using FarmPJ.Models;
using FarmPJ.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FarmPJ
{
    public partial class animalForm : Form
    {
        private AnimalService _animalService;
        private AnimalDTO _animalDTO;

        public animalForm()
        {
            InitializeComponent();
            _animalDTO = new AnimalDTO();
            _animalService = new AnimalService();
            animalGridView.AutoGenerateColumns = false;
        }

        private void cb_AnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (animalGridView.CurrentRow.Index == -1) return;

            _animalDTO.AnimalId = (int)Convert.ToInt64(animalGridView.CurrentRow.Cells["dgAnimalID"].Value);

            var selectedAnimal = _animalService.GetAllAnimals()
                 .FirstOrDefault(a => a.AnimalId == _animalDTO.AnimalId);

            if (selectedAnimal == null || selectedAnimal.AnimalTypeId == 0) return;

            cb_AnimalType.SelectedValue = selectedAnimal.AnimalTypeId;
            txt_Milk.Text = selectedAnimal.Milk.ToString();
            txt_ChildCount.Text = selectedAnimal.ChildCount.ToString();
            txt_Count.Text = selectedAnimal.Count.ToString();

            btn_Delete.Enabled = true;
        }

        private void txt_Milk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ChildCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Count_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!isAllFieldNotEmpty())
            {
                MessageBox.Show("Có trường thông tin còn trống, vui lòng nhập đủ");
                return;
            }
            MessageBox.Show("Tiến hành lưu dữ liệu mới");
            _animalDTO.AnimalTypeId = (int)cb_AnimalType.SelectedValue;
            _animalDTO.Milk = double.Parse(txt_Milk.Text.Trim());
            _animalDTO.Count = int.Parse(txt_Count.Text.Trim());
            _animalDTO.ChildCount = int.Parse(txt_ChildCount.Text.Trim());
            _animalService.SaveAnimal(_animalDTO);
            LoadAnimalData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có muốn xóa hàng gia súc này không ?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            _animalService.DeleteAnimal(_animalDTO.AnimalId);
            LoadAnimalData();
            ResetField();
            MessageBox.Show("Xóa hàng gia súc thành công!");
        }



        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ResetField();
            cb_AnimalType.SelectedIndex = -1;
        }



        private void animalGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void animalForm_Load(object sender, EventArgs e)
        {
            LoadAnimalData();
            LoadAnimalTypes();
        }

        private bool isAllFieldNotEmpty()
        {
            // check if the fields are empty
            if (cb_AnimalType.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn loại gia súc !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_AnimalType.Focus();
                return false;
            }

            if (txt_Milk.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền lượng sữa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Milk.Focus();
                return false;
            }

            if (txt_Count.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền số lượng gia súc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Count.Focus();
                return false;
            }

            if (txt_ChildCount.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền số lượng đẻ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ChildCount.Focus();
                return false;
            }
            return true;
        }

        private void ResetField()
        {
            cb_AnimalType.SelectedIndex = -1;
            txt_Milk.Clear();
            txt_ChildCount.Clear();
            txt_Count.Clear();

            btn_Delete.Enabled = false;
        }

        private void LoadAnimalData()
        {
            var animals = _animalService.GetAllAnimals();
            animalGridView.DataSource = null;
            animalGridView.DataSource = animals;
        }

        private void LoadAnimalTypes()
        {

            // Specify the property to display
            cb_AnimalType.DisplayMember = "AnimalTypeName";  // Property to display in the dropdown

            // Specify the property to use for the SelectedValue
            cb_AnimalType.ValueMember = "AnimalTypeID";  // Property to use as value
            var animalTypes = _animalService.GetAllAnimalTypes();

            cb_AnimalType.DataSource = animalTypes;
        }

        private void txt_Milk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_ChildCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_Eval_Click(object sender, EventArgs e)
        {
            string caption = "Trạng thái sau lứa mới sinh";
            string body = "";
            double totalMilk = 0;
            Random random = new Random();
            foreach (DataGridViewRow row in animalGridView.Rows)
            {
                if (row.DataBoundItem is AnimalDTO animal)
                {
                    int childs = random.Next(0, 10);
                    double milk = 0;
                    int previousAnimalCount = animal.Count;
                    animal.Count += childs;
                    switch (animal.AnimalTypeName)
                    {
                        case "Cow":
                            milk = Math.Round(
                                random.NextDouble() * 20
                                , 1) * previousAnimalCount;
                            body += $"Số bò sau sinh: {animal.Count}\r\n";
                            break;
                        case "Sheep":
                            milk = Math.Round(
                                random.NextDouble() * 5
                                , 1) * previousAnimalCount;
                            body += $"Số cừu sau sinh: {animal.Count}\r\n";
                            break;
                        case "Goat":
                            milk = Math.Round(
                                random.NextDouble() * 10
                                , 1) * previousAnimalCount;
                            body += $"Số dê sau sinh: {animal.Count}\r\n";
                            break;
                        default:
                            break;
                    }
                    totalMilk += milk;
                    _animalService.SaveAnimal(animal);
                }
            }
            body += $"Tổng số sữa thu được: {totalMilk}(l)";

            MessageBox.Show(body, caption);

            animalGridView.Refresh();
        }

        private void btn_Sound_Click(object sender, EventArgs e)
        {
            string sounds = "";
            foreach (DataGridViewRow row in animalGridView.Rows)
            {
                if (row.DataBoundItem is AnimalDTO animal)
                {
                    string sound = animal.Sound;
                    int count = animal.Count;

                    sounds = sounds + string.Join(" ", Enumerable.Repeat(sound, count)) + "\r\n";
                }
            }
            MessageBox.Show(sounds, "Tiếng kêu");
        }
    }
}

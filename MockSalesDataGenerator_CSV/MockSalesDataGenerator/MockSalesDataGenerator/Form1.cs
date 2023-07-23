using System.Text;

namespace MockSalesDataGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox_FolderPath.Text = System.IO.Directory.GetCurrentDirectory();

            List<Products> products = new List<Products>();
            products.Add(new Products("�m�[�g�p�\�R��", 120000, 60000, 1, 5, 30));
            products.Add(new Products("�f�X�N�g�b�v�p�\�R��", 150000, 75000, 2, 5, 30));
            products.Add(new Products("�v�����^�[", 40000, 20000, 0, 5, 30));

            // DataGridView�ɐ��i�̃��X�g���o�C���h���܂��B
            DataGridViewProducts.DataSource = products;

        }

        private void button_GenerateData_Click(object sender, EventArgs e)
        {
            //dateTimePicker1�̒l���J�n���Ƃ��Ď擾����B���Ԃ�00:00:00�Ƃ���B
            DateTime startDate = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 0, 0, 0);

            //dateTimePicker2�̒l���I�����Ƃ��Ď擾����B���Ԃ�23:59:59�Ƃ���B
            DateTime endDate = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, 23, 59, 59);


            //dateTimePicker3�̒l���L�����y�[���J�n���Ƃ��Ď擾����B���Ԃ�00:00:00�Ƃ���B
            DateTime campaignStartDate = new DateTime(dateTimePicker3.Value.Year, dateTimePicker3.Value.Month, dateTimePicker3.Value.Day, 0, 0, 0);

            //dateTimePicker4�̒l���L�����y�[���I�����Ƃ��Ď擾����B���Ԃ�23:59:59�Ƃ���B
            DateTime campaignEndDate = new DateTime(dateTimePicker4.Value.Year, dateTimePicker4.Value.Month, dateTimePicker4.Value.Day, 23, 59, 59);




            //startDate����endDate���O�̓��t�̏ꍇ�A�G���[���b�Z�[�W��\������B
            if (startDate > endDate)
            {
                MessageBox.Show("�I�����͊J�n���ȍ~�̓��t��I�����Ă��������B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //campaignStartDate����campaignEndDate���O�̓��t�̏ꍇ�A�G���[���b�Z�[�W��\������B
            if (campaignStartDate > campaignEndDate)
            {
                MessageBox.Show("�L�����y�[���I�����̓L�����y�[���J�n���ȍ~�̓��t��I�����Ă��������B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //startDate����campaignStartDate���O�̓��t�̏ꍇ�A�G���[���b�Z�[�W��\������B
            if (startDate > campaignStartDate)
            {
                MessageBox.Show("�L�����y�[���J�n���͊J�n���ȍ~�̓��t��I�����Ă��������B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //endDate����campaignEndDate����̓��t�̏ꍇ�A�G���[���b�Z�[�W��\������B
            if (endDate < campaignEndDate)
            {
                MessageBox.Show("�L�����y�[���I�����͏I�����ȑO�̓��t��I�����Ă��������B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //textBox_accessRate�̒l�����l�łȂ��ꍇ�A�G���[���b�Z�[�W��\������B
            int n;
            if (!int.TryParse(textBox_accessRate.Text, out n))
            {
                MessageBox.Show("�A�N�Z�X���ɂ͐��l����͂��Ă��������B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //textBox_NumOfUsers�̒l�����l�łȂ��ꍇ�A�G���[���b�Z�[�W��\������B
            if (!int.TryParse(textBox_NumOfUsers.Text, out n))
            {
                MessageBox.Show("���[�U�[���ɂ͐��l����͂��Ă��������B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //textBox_purchaseRate�̒l�����l�łȂ��ꍇ�A�G���[���b�Z�[�W��\������B
            if (!int.TryParse(textBox_purchaseFactor.Text, out n))
            {
                MessageBox.Show("�w���W���ɂ͐��l����͂��Ă��������B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //textBox_cancellationRate�̒l�����l�łȂ��ꍇ�A�G���[���b�Z�[�W��\������B
            if (!int.TryParse(textBox_cancellationRate.Text, out n))
            {
                MessageBox.Show("�L�����Z�����ɂ͐��l����͂��Ă��������B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //textBox_DiscountRate�̒l�����l�łȂ��ꍇ�A�G���[���b�Z�[�W��\������B
            if (!int.TryParse(textBox_DiscountRate.Text, out n))
            {
                MessageBox.Show("�������ɂ͐��l����͂��Ă��������B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //textBox_AccelerationRate�̒l�����l�łȂ��ꍇ�A�G���[���b�Z�[�W��\������B
            if (!int.TryParse(textBox_AccelerationRate.Text, out n))
            {
                MessageBox.Show("�����x�ɂ͐��l����͂��Ă��������B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //textBox_NumOfUsers����A���[�U�[�����擾����B
            int numOfUsers = int.Parse(textBox_NumOfUsers.Text);

            //textBox_accessRate����A�A�N�Z�X�����擾����B
            int accessRate = int.Parse(textBox_accessRate.Text);

            //textBox_purchaseRate����A�w���W�����擾����B
            int purchasepurchaseFactor = int.Parse(textBox_purchaseFactor.Text);

            //textBox_cancellationRate����A�L�����Z�������擾����B
            int cancellationRate = int.Parse(textBox_cancellationRate.Text);

            //textBox_DiscountRate����A���������擾����B
            int discountRate = int.Parse(textBox_DiscountRate.Text);

            //textBox_AccelerationRate����A�w�������x���擾����B�܂��A��Z�̂��߁A0.01����Z���A1�����Z����B
            double accelerationRate = double.Parse(textBox_AccelerationRate.Text) * 0.01 + 1;

            //textBox_FolderPath����A�t�H���_�p�X���擾����B
            string CsvOutputfolderPath = textBox_FolderPath.Text;


            //List<Products> products = new List<Products>();
            //products.Add(new Products("�m�[�g�p�\�R��", 120000, 60000, 1, 5, 30));
            //products.Add(new Products("�f�X�N�g�b�v�p�\�R��", 150000, 75000, 2, 5, 30));
            //products.Add(new Products("�v�����^�[", 40000, 20000, 0, 5, 30));
            List<Products> products = (List<Products>)DataGridViewProducts.DataSource;

            int SalesID = 0;



            for (DateTime time = startDate; time <= endDate; time = time.AddMinutes(1))
            {

                //�A�N�Z�X�������ɖ߂��B
                accessRate = int.Parse(textBox_accessRate.Text);

                //�L�����y�[�����ԓ��̏ꍇ�A�A�N�Z�X��������������B
                if (time >= campaignStartDate && time <= campaignEndDate)
                {
                    //�A�N�Z�X��������������B
                    accessRate = (int)(accessRate * accelerationRate);
                }


                //accessRate�̒l�̊m���ŁA�A�N�Z�X���������Ƃ���B
                if (new Random().Next(0, 100) < accessRate)
                {
                    //UserID��numOfUsers�̒l���烉���_���ɐ�������B���ɁuU�v��t���A���̐�����5���ɂ���B
                    string UserID = "U" + new Random().Next(0, numOfUsers).ToString("00000");

                    //�^���J�[�g�̒��g��ێ����郊�X�g
                    List<Products> cart = new List<Products>();

                    //�l�C���ɂ��A���i�̕��ёւ�
                    //products.Sort((a, b) => b.Popularity.CompareTo(a.Popularity));

                    //���ԃJ�E���g�p�ϐ�
                    //int PopularityCount = 0;

                    //PurchaseProbability�p�ϐ�
                    int PurchaseProbability = 0;

                    //PurchaseProbability��Z�p�ϐ�
                    double PurchaseProbabilityMultiplication = 2;

                    foreach (Products products1 in products)
                    {
                        //PurchaseProbabilityUpperLimit��PurchaseProbabilityLowerLimit�̊ԂŃ����_���Ȓl��PurchaseProbability�ɑ������B
                        PurchaseProbability = new Random().Next(products1.PurchaseProbabilityLowerLimit, products1.PurchaseProbabilityUpperLimit);

                        //PurchaseProbability�̒l�̊m���ŁA���̐��i�ɃA�N�Z�X���������Ƃ���B�܂��A�L�����y�[�����ԓ��̏ꍇ�A�w����������������B�܂��A�l�C���Ⴂ���APurchaseProbabilityMultiplication���g�p���A�w����������������B
                        if (new Random().Next(0, 100) < PurchaseProbability - (products1.Popularity * PurchaseProbabilityMultiplication))
                        {
                            //AccessLog.csv�����݂��Ȃ��ꍇ�A�V�K�쐬���A�w�b�_�[���������ށB
                            if (!File.Exists(CsvOutputfolderPath + "\\" + "AccessLog.csv"))
                            {
                                //�J�����g�f�B���N�g�������ɁACSV�t�@�C�����쐬�A�܂��͒ǋL����B
                                using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "AccessLog.csv", true, Encoding.UTF8))
                                {
                                    //CSV�t�@�C���ɏ������ށB
                                    sw.WriteLine("DateTime,UserID,Operation");
                                }
                            }

                            //AccessLog.csv�ɒǋL����B
                            using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "AccessLog.csv", true, Encoding.UTF8))
                            {
                                //CSV�t�@�C���ɏ������ށB
                                sw.WriteLine(time.ToString("yyyy/MM/dd HH:mm:ss") + "," + UserID + "," + "Page Access:" + products1.ProductName);
                            }

                            //PurchaseProbability�l�̍Đ���
                            PurchaseProbability = new Random().Next(products1.PurchaseProbabilityLowerLimit, products1.PurchaseProbabilityUpperLimit);

                            //PurchaseProbability�̒l��purchasepurchaseFactor�̒l�ɂ��m���ŁA�J�[�g�ɓ���鑀�삪�������Ƃ���B
                            if (new Random().Next(0, 100) < PurchaseProbability + purchasepurchaseFactor)
                            {
                                //AccessLog.csv�ɒǋL����
                                using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "AccessLog.csv", true, Encoding.UTF8))
                                {
                                    //CSV�t�@�C���ɏ������ށB
                                    sw.WriteLine(time.ToString("yyyy/MM/dd HH:mm:ss") + "," + UserID + "," + "Add to Cart:" + products1.ProductName);
                                }



                                //cancellationRate�̊m���ŁA�L�����Z�����������Ƃ���B
                                if (new Random().Next(0, 100) < cancellationRate)
                                {
                                    //�J�����g�f�B���N�g�������ɁACSV�t�@�C�����쐬�A�܂��͒ǋL����B
                                    using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "AccessLog.csv", true, Encoding.UTF8))
                                    {
                                        //CSV�t�@�C���ɏ������ށB
                                        sw.WriteLine(time.ToString("yyyy/MM/dd HH:mm:ss") + "," + UserID + "," + "Remove from Cart:" + products1.ProductName);
                                    }
                                }
                                else
                                {
                                    //cart�ɒǉ�����B
                                    cart.Add(products1);


                                }
                            }


                        }

                    }


                    //cart�ɏ��i�������Ă���ꍇ�A�w���������s���B
                    if (cart.Count > 0)
                    {
                        //�J�����g�f�B���N�g�������ɁACSV�t�@�C�����쐬�A�܂��͒ǋL����B
                        using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "AccessLog.csv", true, Encoding.UTF8))
                        {
                            //CSV�t�@�C���ɏ������ށB
                            sw.WriteLine(time.ToString("yyyy/MM/dd HH:mm:ss") + "," + UserID + "," + "Purchase");
                        }

                        SalesID = SalesID + 1;

                        //SalesID��6����0���߂ŕ\������B
                        string str_salesID = SalesID.ToString("000000");

                        //cart�̍��v���v�Z����B
                        int total = cart.Sum(x => x.Price);

                        //�J�����g�f�B���N�g�������ɁASalesData.csv���Ȃ��ꍇ�A�w�b�_�[���������ށB
                        if (!File.Exists("SalesData.csv"))
                        {
                            //�J�����g�f�B���N�g�������ɁACSV�t�@�C�����쐬�A�܂��͒ǋL����B
                            using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "SalesData.csv", true, Encoding.UTF8))
                            {
                                //CSV�t�@�C���ɏ������ށB
                                sw.WriteLine("DateTime,SalesID,UserID,SalesAmounts");
                            }
                        }

                        //����グ�f�[�^��SalesData.csv�ɒǋL����B
                        using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "SalesData.csv", true, Encoding.UTF8))
                        {
                            //CSV�t�@�C���ɏ������ށB
                            sw.WriteLine(time.ToString("yyyy/MM/dd HH:mm:ss") + "," + str_salesID + "," + UserID + "," + total);
                        }

                        //���i���Ƃ̔���グ�f�[�^��SalesDataDetail.csv�ɒǋL����B
                        foreach (Products products1 in cart)
                        {
                            //�J�����g�f�B���N�g�������ɁASalesDataDetail.csv���Ȃ��ꍇ�A�w�b�_�[���������ށB
                            if (!File.Exists(CsvOutputfolderPath + "\\" + "SalesDataDetail.csv"))
                            {
                                //�J�����g�f�B���N�g�������ɁACSV�t�@�C�����쐬�A�܂��͒ǋL����B
                                using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "SalesDataDetail.csv", true, Encoding.UTF8))
                                {
                                    //CSV�t�@�C���ɏ������ށB
                                    sw.WriteLine("DateTime,SalesID,ProductName,Price");
                                }
                            }

                            //����グ�f�[�^��SalesDataDetail.csv�ɒǋL����B
                            using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "SalesDataDetail.csv", true, Encoding.UTF8))
                            {
                                //CSV�t�@�C���ɏ������ށB
                                sw.WriteLine(time.ToString("yyyy/MM/dd HH:mm:ss") + "," + str_salesID + "," + products1.ProductName + "," + products1.Price);
                            }
                        }
                    }

                    //cart��j������B
                    cart.Clear();



                }

                //Thread.Sleep(1);
            }


            MessageBox.Show("�f�[�^��������");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker3.Enabled = true;
                dateTimePicker4.Enabled = true;
                textBox_DiscountRate.Enabled = true;
                textBox_AccelerationRate.Enabled = true;

            }
            else
            {
                dateTimePicker3.Enabled = false;
                dateTimePicker4.Enabled = false;
                textBox_DiscountRate.Enabled = false;
                textBox_AccelerationRate.Enabled = false;

            }
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBox_FolderPath.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
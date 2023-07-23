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
            products.Add(new Products("ノートパソコン", 120000, 60000, 1, 5, 30));
            products.Add(new Products("デスクトップパソコン", 150000, 75000, 2, 5, 30));
            products.Add(new Products("プリンター", 40000, 20000, 0, 5, 30));

            // DataGridViewに製品のリストをバインドします。
            DataGridViewProducts.DataSource = products;

        }

        private void button_GenerateData_Click(object sender, EventArgs e)
        {
            //dateTimePicker1の値を開始日として取得する。時間は00:00:00とする。
            DateTime startDate = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 0, 0, 0);

            //dateTimePicker2の値を終了日として取得する。時間は23:59:59とする。
            DateTime endDate = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, 23, 59, 59);


            //dateTimePicker3の値をキャンペーン開始日として取得する。時間は00:00:00とする。
            DateTime campaignStartDate = new DateTime(dateTimePicker3.Value.Year, dateTimePicker3.Value.Month, dateTimePicker3.Value.Day, 0, 0, 0);

            //dateTimePicker4の値をキャンペーン終了日として取得する。時間は23:59:59とする。
            DateTime campaignEndDate = new DateTime(dateTimePicker4.Value.Year, dateTimePicker4.Value.Month, dateTimePicker4.Value.Day, 23, 59, 59);




            //startDateよりもendDateが前の日付の場合、エラーメッセージを表示する。
            if (startDate > endDate)
            {
                MessageBox.Show("終了日は開始日以降の日付を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //campaignStartDateよりもcampaignEndDateが前の日付の場合、エラーメッセージを表示する。
            if (campaignStartDate > campaignEndDate)
            {
                MessageBox.Show("キャンペーン終了日はキャンペーン開始日以降の日付を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //startDateよりもcampaignStartDateが前の日付の場合、エラーメッセージを表示する。
            if (startDate > campaignStartDate)
            {
                MessageBox.Show("キャンペーン開始日は開始日以降の日付を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //endDateよりもcampaignEndDateが後の日付の場合、エラーメッセージを表示する。
            if (endDate < campaignEndDate)
            {
                MessageBox.Show("キャンペーン終了日は終了日以前の日付を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //textBox_accessRateの値が数値でない場合、エラーメッセージを表示する。
            int n;
            if (!int.TryParse(textBox_accessRate.Text, out n))
            {
                MessageBox.Show("アクセス率には数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //textBox_NumOfUsersの値が数値でない場合、エラーメッセージを表示する。
            if (!int.TryParse(textBox_NumOfUsers.Text, out n))
            {
                MessageBox.Show("ユーザー数には数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //textBox_purchaseRateの値が数値でない場合、エラーメッセージを表示する。
            if (!int.TryParse(textBox_purchaseFactor.Text, out n))
            {
                MessageBox.Show("購入係数には数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //textBox_cancellationRateの値が数値でない場合、エラーメッセージを表示する。
            if (!int.TryParse(textBox_cancellationRate.Text, out n))
            {
                MessageBox.Show("キャンセル率には数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //textBox_DiscountRateの値が数値でない場合、エラーメッセージを表示する。
            if (!int.TryParse(textBox_DiscountRate.Text, out n))
            {
                MessageBox.Show("割引率には数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //textBox_AccelerationRateの値が数値でない場合、エラーメッセージを表示する。
            if (!int.TryParse(textBox_AccelerationRate.Text, out n))
            {
                MessageBox.Show("加速度には数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //textBox_NumOfUsersから、ユーザー数を取得する。
            int numOfUsers = int.Parse(textBox_NumOfUsers.Text);

            //textBox_accessRateから、アクセス率を取得する。
            int accessRate = int.Parse(textBox_accessRate.Text);

            //textBox_purchaseRateから、購入係数を取得する。
            int purchasepurchaseFactor = int.Parse(textBox_purchaseFactor.Text);

            //textBox_cancellationRateから、キャンセル率を取得する。
            int cancellationRate = int.Parse(textBox_cancellationRate.Text);

            //textBox_DiscountRateから、割引率を取得する。
            int discountRate = int.Parse(textBox_DiscountRate.Text);

            //textBox_AccelerationRateから、購入加速度を取得する。また、乗算のため、0.01を乗算し、1を加算する。
            double accelerationRate = double.Parse(textBox_AccelerationRate.Text) * 0.01 + 1;

            //textBox_FolderPathから、フォルダパスを取得する。
            string CsvOutputfolderPath = textBox_FolderPath.Text;


            //List<Products> products = new List<Products>();
            //products.Add(new Products("ノートパソコン", 120000, 60000, 1, 5, 30));
            //products.Add(new Products("デスクトップパソコン", 150000, 75000, 2, 5, 30));
            //products.Add(new Products("プリンター", 40000, 20000, 0, 5, 30));
            List<Products> products = (List<Products>)DataGridViewProducts.DataSource;

            int SalesID = 0;



            for (DateTime time = startDate; time <= endDate; time = time.AddMinutes(1))
            {

                //アクセス率を元に戻す。
                accessRate = int.Parse(textBox_accessRate.Text);

                //キャンペーン期間内の場合、アクセス率を加速させる。
                if (time >= campaignStartDate && time <= campaignEndDate)
                {
                    //アクセス率を加速させる。
                    accessRate = (int)(accessRate * accelerationRate);
                }


                //accessRateの値の確率で、アクセスがあったとする。
                if (new Random().Next(0, 100) < accessRate)
                {
                    //UserIDをnumOfUsersの値からランダムに生成する。頭に「U」を付け、後ろの数字は5桁にする。
                    string UserID = "U" + new Random().Next(0, numOfUsers).ToString("00000");

                    //疑似カートの中身を保持するリスト
                    List<Products> cart = new List<Products>();

                    //人気順による、製品の並び替え
                    //products.Sort((a, b) => b.Popularity.CompareTo(a.Popularity));

                    //順番カウント用変数
                    //int PopularityCount = 0;

                    //PurchaseProbability用変数
                    int PurchaseProbability = 0;

                    //PurchaseProbability乗算用変数
                    double PurchaseProbabilityMultiplication = 2;

                    foreach (Products products1 in products)
                    {
                        //PurchaseProbabilityUpperLimitとPurchaseProbabilityLowerLimitの間でランダムな値をPurchaseProbabilityに代入する。
                        PurchaseProbability = new Random().Next(products1.PurchaseProbabilityLowerLimit, products1.PurchaseProbabilityUpperLimit);

                        //PurchaseProbabilityの値の確率で、その製品にアクセスがあったとする。また、キャンペーン期間内の場合、購入率を加速させる。また、人気が低い程、PurchaseProbabilityMultiplicationを使用し、購入率を減速させる。
                        if (new Random().Next(0, 100) < PurchaseProbability - (products1.Popularity * PurchaseProbabilityMultiplication))
                        {
                            //AccessLog.csvが存在しない場合、新規作成し、ヘッダーを書き込む。
                            if (!File.Exists(CsvOutputfolderPath + "\\" + "AccessLog.csv"))
                            {
                                //カレントディレクトリ直下に、CSVファイルを作成、または追記する。
                                using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "AccessLog.csv", true, Encoding.UTF8))
                                {
                                    //CSVファイルに書き込む。
                                    sw.WriteLine("DateTime,UserID,Operation");
                                }
                            }

                            //AccessLog.csvに追記する。
                            using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "AccessLog.csv", true, Encoding.UTF8))
                            {
                                //CSVファイルに書き込む。
                                sw.WriteLine(time.ToString("yyyy/MM/dd HH:mm:ss") + "," + UserID + "," + "Page Access:" + products1.ProductName);
                            }

                            //PurchaseProbability値の再生成
                            PurchaseProbability = new Random().Next(products1.PurchaseProbabilityLowerLimit, products1.PurchaseProbabilityUpperLimit);

                            //PurchaseProbabilityの値とpurchasepurchaseFactorの値による確率で、カートに入れる操作があったとする。
                            if (new Random().Next(0, 100) < PurchaseProbability + purchasepurchaseFactor)
                            {
                                //AccessLog.csvに追記する
                                using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "AccessLog.csv", true, Encoding.UTF8))
                                {
                                    //CSVファイルに書き込む。
                                    sw.WriteLine(time.ToString("yyyy/MM/dd HH:mm:ss") + "," + UserID + "," + "Add to Cart:" + products1.ProductName);
                                }



                                //cancellationRateの確率で、キャンセルがあったとする。
                                if (new Random().Next(0, 100) < cancellationRate)
                                {
                                    //カレントディレクトリ直下に、CSVファイルを作成、または追記する。
                                    using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "AccessLog.csv", true, Encoding.UTF8))
                                    {
                                        //CSVファイルに書き込む。
                                        sw.WriteLine(time.ToString("yyyy/MM/dd HH:mm:ss") + "," + UserID + "," + "Remove from Cart:" + products1.ProductName);
                                    }
                                }
                                else
                                {
                                    //cartに追加する。
                                    cart.Add(products1);


                                }
                            }


                        }

                    }


                    //cartに商品が入っている場合、購入処理を行う。
                    if (cart.Count > 0)
                    {
                        //カレントディレクトリ直下に、CSVファイルを作成、または追記する。
                        using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "AccessLog.csv", true, Encoding.UTF8))
                        {
                            //CSVファイルに書き込む。
                            sw.WriteLine(time.ToString("yyyy/MM/dd HH:mm:ss") + "," + UserID + "," + "Purchase");
                        }

                        SalesID = SalesID + 1;

                        //SalesIDを6桁の0埋めで表示する。
                        string str_salesID = SalesID.ToString("000000");

                        //cartの合計を計算する。
                        int total = cart.Sum(x => x.Price);

                        //カレントディレクトリ直下に、SalesData.csvがない場合、ヘッダーを書き込む。
                        if (!File.Exists("SalesData.csv"))
                        {
                            //カレントディレクトリ直下に、CSVファイルを作成、または追記する。
                            using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "SalesData.csv", true, Encoding.UTF8))
                            {
                                //CSVファイルに書き込む。
                                sw.WriteLine("DateTime,SalesID,UserID,SalesAmounts");
                            }
                        }

                        //売り上げデータをSalesData.csvに追記する。
                        using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "SalesData.csv", true, Encoding.UTF8))
                        {
                            //CSVファイルに書き込む。
                            sw.WriteLine(time.ToString("yyyy/MM/dd HH:mm:ss") + "," + str_salesID + "," + UserID + "," + total);
                        }

                        //製品ごとの売り上げデータをSalesDataDetail.csvに追記する。
                        foreach (Products products1 in cart)
                        {
                            //カレントディレクトリ直下に、SalesDataDetail.csvがない場合、ヘッダーを書き込む。
                            if (!File.Exists(CsvOutputfolderPath + "\\" + "SalesDataDetail.csv"))
                            {
                                //カレントディレクトリ直下に、CSVファイルを作成、または追記する。
                                using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "SalesDataDetail.csv", true, Encoding.UTF8))
                                {
                                    //CSVファイルに書き込む。
                                    sw.WriteLine("DateTime,SalesID,ProductName,Price");
                                }
                            }

                            //売り上げデータをSalesDataDetail.csvに追記する。
                            using (StreamWriter sw = new StreamWriter(CsvOutputfolderPath + "\\" + "SalesDataDetail.csv", true, Encoding.UTF8))
                            {
                                //CSVファイルに書き込む。
                                sw.WriteLine(time.ToString("yyyy/MM/dd HH:mm:ss") + "," + str_salesID + "," + products1.ProductName + "," + products1.Price);
                            }
                        }
                    }

                    //cartを破棄する。
                    cart.Clear();



                }

                //Thread.Sleep(1);
            }


            MessageBox.Show("データ生成完了");

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
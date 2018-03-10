using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Controls;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// DataSetに値を格納するクラス
    /// </summary>
    class DataStorage
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        //コンストラクタ
        public DataStorage()
        {
            // 列追加します。
            dt.Columns.Add("textname");
            dt.Columns.Add("ID");

            // 行追加します。
            dt.Rows.Add();

            //列と行をDataSetに追加
            ds.Tables.Add(dt);
        }

        //DataSetに行を追加し、登録するメソッド
        public void datamanagement(string inserttext)
        {
            //行を追加
            DataRow row = ds.Tables[0].NewRow();
            //値を格納
            row[0] = inserttext;
            //DataSetに追加
            ds.Tables[0].Rows.Add(row);
            //XmlManager xmlmanager = new XmlManager();
            //xmlmanager.Xmlcreater(inserttext);

            StreamWriter sw = new StreamWriter(@"C:\test\test.xml", false,
                                System.Text.Encoding.GetEncoding("Shift_Jis"));

            ds.WriteXml(sw);
            sw.Close();
        }
    }
}
